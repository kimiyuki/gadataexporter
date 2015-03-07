using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Google.Apis;
using Google.Apis.Util.Store;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Analytics.v3;
using Google.Apis.Services;
using Google.Apis.Requests;
using Google.Apis.Analytics.v3.Data;

namespace GA_Data_Exporter
{
    public partial class Form1 : Form
    {
        private AnalyticsService service;
        private UserCredential credential;
        private List<string> dimensionsItems = new List<string>();
        private List<string> metricsItems = new List<string>();
        private AppSettings appSettings = null;

        public Form1()
        {
            InitializeComponent();
            auth();
            getMetaData();
            startDateTextBox.Text = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
            endDateTextBox.Text = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
            indexTextBox.Text = "1";
            getSegments();
            if (Properties.Settings.Default.filepath == "") { 
                filePathTextBox.Text = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal)+ "\\" + "ga.csv";
            }
            else
            {
                filePathTextBox.Text = Properties.Settings.Default.filepath;
            }
            if (Properties.Settings.Default.queryHistories != null )
            {
                foreach (string s in Properties.Settings.Default.queryHistories.Cast<string>().ToList().Take(10)) 
                {
                    putQueryHistory(s);
                } 
            }
            putQueryHistoryClear();
        }

        private void putQueryHistory(string s)
        {
            saveQueryToSystem(s);
            string prm = DateTime.Now.ToString("yyyy/MM/dd H:mm") + " : " + System.Text.RegularExpressions.Regex.Replace(s, @".*ids\=ga:[0-9]+", "");
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Text = prm;
            item.Tag = s;
            item.Click += new EventHandler(queryHistoriesToolStripMenuItem_Click);
            //queryHistoryMenuStrip.Items.Add(item);
            //last position
            queryHistoriesToolStripMenuItem.DropDownItems.Insert(0, item);
        }

        private void saveQueryToSystem(string s)
        {
            Properties.Settings.Default.queryHistories.Add(s);
            Properties.Settings.Default.Save();
        }
        private string _querySpliter(string q)
        {
            return "a";
        }

        private void putQueryHistoryClear()
        {
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Text = "CLEAR";
            item.Tag = "CLEAR";
            item.Click += new EventHandler(queryHistoriesToolStripMenuItem_Click);
            queryHistoriesToolStripMenuItem.DropDownItems.Insert(0, item);

        }

        private void queryHistoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            string args = menuItem.Tag.ToString();
            if (args == "CLEAR")
            {
                Properties.Settings.Default.queryHistories.Clear();
                queryHistoriesToolStripMenuItem.DropDownItems.Clear();
                putQueryHistoryClear();
                return;
            }
            putParametersByMenu(args);
        }

        private void putParametersByMenu(string s)
        {
            var m = System.Text.RegularExpressions.Regex.Split(s, @"\?|\&");
            Dictionary<string,string> dic = new Dictionary<string,string>();
            dic = m.Select(c => c.Split('=')).Where(c => c.Length > 1).ToDictionary(e => e[0], e => e[1]);
            if (dic.ContainsKey("metrics")) metricsTextBox.Text = dic["metrics"];
            if (dic.ContainsKey("start-date")) startDateTextBox.Text = dic["start-date"];
      }

        private void AuthChangeButton_Click(object sender, EventArgs e)
        {
            (new FileDataStore("ga")).ClearAsync();
            auth();
            getAccounts();
        }

        private void buttonDeleteAuth_Click(object sender, EventArgs e)
        {
            (new FileDataStore("ga")).ClearAsync();
        }

        private void auth()
        {

            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                           new ClientSecrets
                           {
                               ClientId = "374992669151-gq3ge9ps7clrvdkr6r4kmqamlcbesqfp.apps.googleusercontent.com",
                               ClientSecret = "mIUGfAhjITR1qqv7CgAXK4BY"
                           },
                           new[] { AnalyticsService.Scope.AnalyticsReadonly },
                           "user", CancellationToken.None, new FileDataStore("ga")).Result;
            service = new AnalyticsService(
               new BaseClientService.Initializer()
               {
                   HttpClientInitializer = credential,
                   ApplicationName = "abc-analytics ga data exporter"
               });
            getAccounts();
        }
   
        private void getMetaData()
        {
            MetadataResource.ColumnsResource.ListRequest req = service.Metadata.Columns.List("ga");
            Columns metadataList = req.Execute();
            IList<Column> items = metadataList.Items;
            var sitems = items.Where(c => c.Attributes["status"] != "DEPRECATED").ToList();
            sitems = sitems.Where(c => !c.Id.Contains("dcm")).ToList();
            var metrics = sitems.Where(c => c.Attributes["type"] == "METRIC").ToList();
            for (int k = 0; k < metrics.Count; k++)
            {
                var metric = metrics[k];
                if (metric.Attributes.ContainsKey("minTemplateIndex"))
                {
                    for (var i = Convert.ToInt32(metric.Attributes["minTemplateIndex"]); i < Convert.ToInt32(metric.Attributes["maxTemplateIndex"]) + 1; i++)
                    {
                        metricsItems.Add(metric.Id.Replace("ga:", "").Replace("XX",i.ToString()) + "," + metric.Attributes["group"]);
                        ListViewItem item = new ListViewItem(metric.Id.Replace("ga:", "").Replace("XX",i.ToString()));
                        item.ToolTipText = metric.Attributes["group"] + ":" + metric.Attributes["description"] + ":" + metric.Attributes["uiName"];
                        listViewMetrics.Items.Add(item);
                    }

                }
                else
                {
                    metricsItems.Add(metric.Id.Replace("ga:", "") + "," + metric.Attributes["group"]);
                    ListViewItem item = new ListViewItem(metric.Id.Replace("ga:", ""));
                    item.ToolTipText = metric.Attributes["group"] + ":" + metric.Attributes["description"] + ":" + metric.Attributes["uiName"];
                    listViewMetrics.Items.Add(item);
                }
              
            }
            var dims = sitems.Where(c => c.Attributes["type"] == "DIMENSION").ToList();
            for (int k = 0; k < dims.Count; k++)
            {
                var dim = dims[k];
                if (dim.Attributes.ContainsKey("minTemplateIndex"))
                {
                    for (var i = Convert.ToInt32(dim.Attributes["minTemplateIndex"]); i < Convert.ToInt32(dim.Attributes["maxTemplateIndex"]); i++)
                    {
                        dimensionsItems.Add(dim.Id.Replace("ga:", "").Replace("XX",i.ToString()) + "," + dim.Attributes["group"]);
                        ListViewItem item = new ListViewItem(dim.Id.Replace("ga:", "").Replace("XX",i.ToString()));
                        item.ToolTipText = dim.Attributes["group"] + ":" + dim.Attributes["description"] + ":" + dim.Attributes["uiName"];
                        listViewDimensions.Items.Add(item);
                    }
                }
                else
                {
                    dimensionsItems.Add(dim.Id.Replace("ga:", "") + "," + dim.Attributes["group"]);
                    ListViewItem item = new ListViewItem(dim.Id.Replace("ga:", ""));
                    item.ToolTipText = dim.Attributes["group"] + ":" + dim.Attributes["description"] + ":" + dim.Attributes["uiName"];
                    listViewDimensions.Items.Add(item);
                }
            }
            var group1 = metricsItems.Select(c =>    System.Text.RegularExpressions.Regex.Replace(c, @".*,", ""));
            var group2 = dimensionsItems.Select(c => System.Text.RegularExpressions.Regex.Replace(c, @".*,", ""));
            var groups = group1.Concat(group2).Distinct();
            foreach (string g in groups)
            {
                groupComboBox.Items.Add(g);
            }
        }



        private void getMetaData1()
        {
            MetadataResource.ColumnsResource.ListRequest req = service.Metadata.Columns.List("ga");
            Columns metadataList = req.Execute();
            IList<Column> items = metadataList.Items;
            var sitems = items.Where(c => c.Attributes["status"] != "DEPRECATED").ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(string));
            dt.Columns.Add("group", typeof(string));
            dt.Columns.Add("ui name", typeof(string));
            dt.Columns.Add("description", typeof(string));
            var metrics = sitems.Where(c => c.Attributes["type"] == "METRIC").ToList();
            for (int k = 0; k < metrics.Count; k++)
            {
                DataRow row = dt.NewRow();
                var metric = metrics[k];
                row[0] = metrics[k].Id.Replace("ga:","");
                row[1] = metrics[k].Attributes["group"];
                row[2] = metrics[k].Attributes["uiName"];
                row[3] = metrics[k].Attributes["description"];
                dt.Rows.Add(row);
            }
        
            var dimensions = sitems.Where(c => c.Attributes["type"] == "DIMENSION").ToList();
            for (int k = 0; k < dimensions.Count; k++)
            {
                DataRow row = dt.NewRow();
                row[0] = dimensions[k].Id.Replace("ga:", "");
                row[1] = dimensions[k].Attributes["group"];
                row[2] = dimensions[k].Attributes["uiName"];
                row[3] = dimensions[k].Attributes["description"];
                dt.Rows.Add(row);
            }
            this.dataGridViewDimMetrics.DataSource = dt;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            getAccounts();
        }
        private void getAccounts()
        {
            ManagementResource.AccountsResource.ListRequest req = service.Management.Accounts.List();
            Accounts accountList = req.Execute();
            IList<Account> acs = accountList.Items;
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("id", typeof(string));
            dt1.Columns.Add("name", typeof(string));
            dt1.Columns.Add("updated",typeof(string));
            for(int i=0; i< acs.Count;i++){
                DataRow row = dt1.NewRow();
                row[0] = acs[i].Id;
                row[1] = acs[i].Name;
                row[2] = acs[i].Updated;
                dt1.Rows.Add(row);
            }
            this.accountDataGridView.DataSource = dt1;

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              if (e.RowIndex < 0) return; //header時の対処
              DataGridViewCell cell = (DataGridViewCell)accountDataGridView.Rows[e.RowIndex].Cells[0];
              string id = cell.Value.ToString();
              getWebProperty(id);

        }
        private void getSegments()
        {
            ManagementResource.SegmentsResource.ListRequest req = service.Management.Segments.List();
            Segments segs =  req.Execute();
            DataTable dt = new DataTable();
            dt.Columns.Add("name",typeof(string));
            dt.Columns.Add("segmentId", typeof(string));
            dt.Columns.Add("updated", typeof(string));
            dt.Columns.Add("definition", typeof(string));
            foreach (var item in segs.Items)
            {
               DataRow row = dt.NewRow();
               row[0] = item.Name;
               row[1] = item.SegmentId;
               row[2] = item.Updated.HasValue ? item.Updated.ToString() : "";
               row[3] = item.Definition;
               dt.Rows.Add(row);
            }
            segmentDataGridView.DataSource = dt;
        }


        private void getWebProperty(string aid){
          
            //IDを取得するので、cell[0]
            ManagementResource.WebpropertiesResource.ListRequest req = service.Management.Webproperties.List(aid);
            Webproperties wpr = req.Execute();
            IList<Webproperty> wps = wpr.Items;
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(string));
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("updated", typeof(string));
            dt.Columns.Add("industry", typeof(string));
            dt.Columns.Add("accountId", typeof(string));
            for (int i = 0; i < wps.Count; i++)
            {
                DataRow row = dt.NewRow();
                row[0] = wps[i].Id;
                row[1] = wps[i].Name;
                row[2] = wps[i].Updated;
                row[3] = wps[i].IndustryVertical;
                row[4] = wps[i].AccountId;
                dt.Rows.Add(row);
            }
            this.propertyDataGridView.DataSource = dt;
        }
        private void dataGridViewWebProperty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; //header時の対処
            string wid =  propertyDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            string aid = propertyDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            ManagementResource.ProfilesResource.ListRequest req = service.Management.Profiles.List(aid, wid);
            Profiles ret = req.Execute();
            IList<Profile> views = ret.Items;
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(string));
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("updated", typeof(string));
            dt.Columns.Add("aid",typeof(string));
            dt.Columns.Add("wid",typeof(string));
            for (int i = 0; i < views.Count; i++)
            {
                DataRow row = dt.NewRow();
                row[0] = views[i].Id;
                row[1] = views[i].Name;
                row[2] = views[i].Updated;
                row[3] = views[i].AccountId;
                row[4] = views[i].WebPropertyId;
                dt.Rows.Add(row);
            }
            this.GaViewDataGridView.DataSource = dt;
        }
        private void dataGridViewViews_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; //header時の対処
            string aid = GaViewDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            string wid = GaViewDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            string vid = GaViewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            getGoals(aid, wid, vid);
            getViewConf(aid, wid, vid);
        }

        private void getViewConf(string aid, string wid, string vid)
        {
            ManagementResource.ProfilesResource.GetRequest req = service.Management.Profiles.Get(aid, wid, vid);
            Profile ret = req.Execute();
            DataTable dt = makeTable(ret);
            viewDetailDataGridView.DataSource = dt;
        }
        private DataTable makeTable(Profile ret){
            DataTable dt = new DataTable();
            dt.Columns.Add("key", typeof(string));
            dt.Columns.Add("value", typeof(string));
            DataRow row = dt.NewRow(); 
            row[0] = "viewName"; row[1] = ret.Name; dt.Rows.Add(row);
            row = dt.NewRow(); row[0] = "url"; row[1] = ret.WebsiteUrl; dt.Rows.Add(row);
            row = dt.NewRow(); row[0] = "timeZone"; row[1] = ret.Timezone; dt.Rows.Add(row);
            row = dt.NewRow(); row[0] = "defaultPage"; row[1] = ret.DefaultPage; dt.Rows.Add(row);
            row = dt.NewRow(); row[0] = "exclude parameters"; row[1] = ret.ExcludeQueryParameters; dt.Rows.Add(row);
            row = dt.NewRow(); row[0] = "currency"; row[1] = ret.Currency; dt.Rows.Add(row);
            row = dt.NewRow(); row[0] = "siteSearch"; row[1] = ret.SiteSearchQueryParameters; dt.Rows.Add(row);
            row = dt.NewRow(); row[0] = "stripSiteSearchParam"; row[1] = ret.StripSiteSearchQueryParameters; dt.Rows.Add(row);
            row = dt.NewRow(); row[0] = "siteSearchCategory"; row[1] = ret.SiteSearchCategoryParameters; dt.Rows.Add(row);
            row = dt.NewRow(); row[0] = "stripSiteSearchCategoryParam"; row[1] = ret.StripSiteSearchCategoryParameters; dt.Rows.Add(row);
            row = dt.NewRow(); row[0] = "ecommerce"; row[1] = ret.ECommerceTracking; dt.Rows.Add(row);
            row = dt.NewRow(); row[0] = "enhancedEcommerce"; row[1] = ret.EnhancedECommerceTracking; dt.Rows.Add(row);
            return dt;
        }
        private void getGoals(string aid, string wid, string vid){
            ManagementResource.GoalsResource.ListRequest req = service.Management.Goals.List(aid, wid, vid);
            Goals ret = req.Execute();
            IList<Goal> goals = ret.Items;
           
            DataTable dt = new DataTable();
            dt.Columns.Add("no", typeof(string));
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("matchType:CaseSensitive", typeof(string));
            dt.Columns.Add("target", typeof(string));
            dt.Columns.Add("value", typeof(string));
            dt.Columns.Add("active", typeof(string));
            dt.Columns.Add("type", typeof(string));
            dt.Columns.Add("updated", typeof(string));
           
            if (goals != null)
            {
                for (int i = 0; i < goals.Count; i++)
                {
                    DataRow row = dt.NewRow();
                    row[0] = goals[i].Id;
                    row[1] = goals[i].Name;
                    if (goals[i].Type == "EVENT")
                    {
                        row[2] = "";
                        row[3] = string.Join(":  ", goals[i].EventDetails.EventConditions.Select(g => g.Type + " " + g.MatchType + " " + g.Expression + " " +  g.ComparisonType + " " + g.ComparisonValue));
                    }
                    else if (goals[i].Type == "URL_DESTINATION")
                    {
                        row[2] = goals[i].UrlDestinationDetails.MatchType + " : " + goals[i].UrlDestinationDetails.CaseSensitive;
                        row[3] = goals[i].UrlDestinationDetails.Url;
                    }
                    else if (goals[i].Type == "VISIT_TIME_ON_SITE")
                    {
                        row[3] = goals[i].VisitTimeOnSiteDetails.ComparisonType + " " + goals[i].VisitTimeOnSiteDetails.ComparisonValue;
                    }
                    else if (goals[i].Type == "VISIT_NUM_PAGES")
                    {
                        row[3] = goals[i].VisitNumPagesDetails.ComparisonType + " " + goals[i].VisitNumPagesDetails.ComparisonValue;
                    }
                    else
                    {
                        row[3] = "special";
                    }
                    row[4] = goals[i].Value;
                    row[5] = goals[i].Active;
                    row[6] = System.Text.RegularExpressions.Regex.Replace(goals[i].Type,@"_.*","");
                    row[7] = System.Text.RegularExpressions.Regex.Replace(goals[i].Updated.ToString(), @"...$","");
           
                    dt.Rows.Add(row);
                }
            }
            this.goalDataGridView.DataSource = dt;
        }

        private bool checkBeforeGetData(){
          
            var cells = GaViewDataGridView.SelectedCells;
            if(cells.Count==0){
                MessageBox.Show("View ID is needed");
                return(false);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(cells[0].Value.ToString(), "^[0-9]+$"))
            {
                MessageBox.Show("viewのIDに問題あり");
                return(false);
            }
          
            if (metricsTextBox.Text == "")
            {
                MessageBox.Show("metrics required");
                return (false);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(startDateTextBox.Text, "[0-9]{4}-[0-9]{2}-[0-9]{2}"))
            {
                MessageBox.Show("invalid startDate");
                return (false);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(endDateTextBox.Text, "[0-9]{4}-[0-9]{2}-[0-9]{2}"))
            {
                MessageBox.Show("invalid endDate");
                return (false);
            }
            return(true);
        }
          private void getAll_Click(object sender, EventArgs e)
        {
            errorTextBox.Text = "";
            if (!checkBeforeGetData())
            {
                return;
            }
            getAll.Enabled = false;
            getData(10000,1);
            getAll.Enabled = true;
            putQueryHistory(queryTextBox.Text);
        }

        private void get1000_Click(object sender, EventArgs e)
        {
            errorTextBox.Text = "";
            if(!checkBeforeGetData()){
                return;
            }
            get1000.Enabled = false;
            getData(1000,1);
            get1000.Enabled = true;
            putQueryHistory(queryTextBox.Text);
        }

        private GaData getGaData(int max, int index)
        {
            string id = GaViewDataGridView.SelectedCells[0].Value.ToString();
            string metrics = metricsTextBox.Text;

            DataResource.GaResource.GetRequest req = service.Data.Ga.Get(
                "ga:" + id,
                startDateTextBox.Text,
                endDateTextBox.Text,
                metrics);
            req.MaxResults = max;
            req.StartIndex = index;
            req.Dimensions = dimensionsTextBox.Text == "" ? null : dimensionsTextBox.Text;
            req.Filters = filterTextBox.Text == "" ? null : filterTextBox.Text;
            req.Sort = sortTextBox.Text == "" ? null : sortTextBox.Text;
            req.Segment = segmentTextBox.Text == "" ? null : segmentTextBox.Text;
            req.SamplingLevel = DataResource.GaResource.GetRequest.SamplingLevelEnum.DEFAULT;
            GaData ret = req.Execute();
            if(ret.ContainsSampledData.Value){
                sampleTextBox.Text = Math.Round((decimal)((float)ret.SampleSize / (float)ret.SampleSpace)*100, 2).ToString() +
                    "%(" + ret.SampleSize.ToString() + "/" + ret.SampleSpace.ToString() +")";
            }else{
                sampleTextBox.Text = "WholeData";
            }
            return(ret);
        }

        private void getData(int max, int index){
            try
            {
                List<GaData> ret = new List<GaData>();
                ret.Add(getGaData(max, 1));
                totalResultsNumtextBox.Text = ret[0].TotalResults.ToString();
                if (ret[0].TotalResults > 10000 && max == 10000)
                {
                    if (ret[0].TotalResults > 100000)
                    {
                        DialogResult msg = MessageBox.Show("over 10,000 rows. want to continue?", "confirm", MessageBoxButtons.YesNo);
                        if (msg == DialogResult.Yes)
                        {
                            return;
                        }
                    }
                    for (int i = 10001; i < ret[0].TotalResults; i = i + 10000)
                    {
                        ret.Add(getGaData(max, i));
                        actualRowsTextBox.Text = i.ToString();
                    }
                }
                queryTextBox.Text = ret[(ret.Count - 1)].SelfLink;


                DataTable dt = new DataTable();
                IList<GaData.ColumnHeadersData> cols = ret[0].ColumnHeaders;
                foreach (GaData.ColumnHeadersData col in cols)
                {
                    if (col.DataType == "FLOAT" || col.DataType == "PERCENT" || col.DataType == "CURRENCY")
                    {
                        dt.Columns.Add(col.Name.Replace("ga:", ""), typeof(float));
                    }
                    else if(col.DataType == "INTEGER")
                    {
                        dt.Columns.Add(col.Name.Replace("ga:", ""), typeof(Int32));
                    }
                    else
                    {
                        dt.Columns.Add(col.Name.Replace("ga:", ""), typeof(string));
                    }
                }
                int numCols = dt.Columns.Count;

                foreach (var r in ret)
                {
                    for (int i = 0; i < r.Rows.Count; i++)
                    {
                        DataRow row = dt.NewRow();
                        for (int j = 0; j < numCols; j++)
                        {
                            row[j] = r.Rows[i][j];
                        }
                        dt.Rows.Add(row);
                    }
                }
                gaDataGridViewData.DataSource = dt;
                actualRowsTextBox.Text = dt.Rows.Count.ToString();
            }
            catch (System.Exception ex)
            {
                errorTextBox.Text = ex.Message;
                return;
            }
        }

        private void listViewMetrics_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var items = listViewMetrics.SelectedItems;
            string ret = "";
            foreach(ListViewItem item in items){
                ret += "ga:" + item.Text + ',';
            }
            metricsTextBox.Text = ret.TrimEnd(',');
            this.labelMetrics.Text = "metrics\n(" + items.Count.ToString() + "/10)";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.metricsTextBox.Clear();
            var items = this.listViewMetrics.SelectedItems;
            this.labelMetrics.Text = "metrics\n(0/10)";
            foreach(ListViewItem item in items){
                item.Selected = false;
            }
        }

        private void buttonClearDims_Click(object sender, EventArgs e)
        {
            this.dimensionsTextBox.Clear();
            var items = this.listViewDimensions.SelectedItems;
            foreach (ListViewItem item in items)
            {
                item.Selected = false;
            }
        }

    
        private void itemFilter_TextChanged(object sender, EventArgs e)
        {
            var str = itemFilter.Text;
            _itemFilter(str);
            
        }
        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var str = groupComboBox.SelectedItem.ToString().ToLower();
            _itemFilter(str);

        }
    
        private void _itemFilter(string str)
        {
            List<string> metItems = new List<string>();
            foreach (ListViewItem i in listViewMetrics.SelectedItems) { metItems.Add(i.Text); }
            listViewMetrics.Items.Clear();
            foreach (string s in metItems)
            {
                listViewMetrics.Items.Add(s);
            }
            foreach (ListViewItem item in listViewMetrics.Items)
            {
                item.Selected = true;
            }

            List<string> dimItems = new List<string>();
            foreach (ListViewItem i in listViewDimensions.SelectedItems) { dimItems.Add(i.Text); }
            listViewDimensions.Items.Clear();
            foreach (string s in dimItems)
            {
                listViewDimensions.Items.Add(s);
            }
            foreach (ListViewItem item in listViewDimensions.Items)
            {
                item.Selected = true;
            }


            if (str.Length < 2)
            {
                foreach (var e in metricsItems) { listViewMetrics.Items.Add(System.Text.RegularExpressions.Regex.Replace(e, @",.*","")); }
                foreach (var e in dimensionsItems) { listViewDimensions.Items.Add(System.Text.RegularExpressions.Regex.Replace(e, @",.*","")); }
                return;
            }

            //metrics
       
            var ar = metricsItems.Where(i => i.ToLower().Contains(str)).Select(c => System.Text.RegularExpressions.Regex.Replace(c, @",.*", ""));
            foreach (var a in ar)
            {
                listViewMetrics.Items.Add(a);
            }

            //dimensions
            
            ar = dimensionsItems.Where(i => i.ToLower().Contains(str)).Select(c => System.Text.RegularExpressions.Regex.Replace(c, @",.*", ""));
            foreach (var a in ar)
            {
                listViewDimensions.Items.Add(a);
            }
        }

        private void listViewDimensions_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var items = listViewDimensions.SelectedItems;
            string ret = "";
            foreach (ListViewItem item in items)
            {
                ret += "ga:" + item.Text + ',';
            }
            dimensionsTextBox.Text = ret.TrimEnd(',');
            this.labelDimensions.Text = "dims\n(" + items.Count.ToString() + "/10)";
    
        }

        private void filterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developers.google.com/analytics/devguides/reporting/core/v3/reference#filters");
        }

        private void sortLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developers.google.com/analytics/devguides/reporting/core/v3/reference#sort");
        }

        private void startLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developers.google.com/analytics/devguides/reporting/core/v3/reference#startIndex");
        }

        private void dateLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developers.google.com/analytics/devguides/reporting/core/v3/reference#startDate");
        }

        private void segmentLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developers.google.com/analytics/devguides/reporting/core/v3/reference#segment");
        }

        private void queryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developers.google.com/analytics/devguides/reporting/core/v3/reference");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string f = filePathTextBox.Text;
            if (File.Exists(f))
            {
               DialogResult ret =  MessageBox.Show("ファイルが存在します。上書きしますか？", "上書きOK？", MessageBoxButtons.YesNo);
               if (ret == DialogResult.No) { return; }
            }
            saveFile(f);
        }

        private void changePathAndSaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            string[] ar = filePathTextBox.Text.Split(new string[]{"\\"}, StringSplitOptions.None);
            sfd.FileName = ar[ar.Length - 1];
            sfd.InitialDirectory = System.Text.RegularExpressions.Regex.Replace(filePathTextBox.Text, @"\.*", "");
            sfd.Filter = "csvファイル|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                saveFile(sfd.FileName);
            }
            
        }

        private void saveFile(string path){
            using (StreamWriter writer = new StreamWriter(path, false, Encoding.GetEncoding("shift_jis")))
            {
                DataGridView dg = gaDataGridViewData;
                int rowCount = dg.Rows.Count;

                // ユーザによる行追加が許可されている場合は、最後に新規入力用の
                // 1行分を差し引く
                if (dg.AllowUserToAddRows == true)
                {
                    rowCount = rowCount - 1;
                }

                //header
                List<string> colList = new List<string>();
                foreach (DataGridViewColumn col in dg.Columns)
                {
                    colList.Add(col.HeaderText);
                }
                writer.WriteLine(String.Join(",", colList.ToArray()));

                // rows
                for (int i = 0; i < rowCount; i++)
                {
                    // リストの初期化
                    List<String> strList = new List<String>();

                    // 列
                    for (int j = 0; j < dg.Columns.Count; j++)
                    {
                        strList.Add(dg[j, i].Value.ToString());
                    }
                    String[] strArray = strList.ToArray();  // 配列へ変換

                    // CSV 形式に変換
                    String strCsvData = String.Join(",", strArray);

                    writer.WriteLine(strCsvData);
                }
            }
            MessageBox.Show("has saved to " + path);
            filePathTextBox.Text = path;
            Properties.Settings.Default.filepath = path;
            Properties.Settings.Default.Save();


        }

        private void プロジェクト情報ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void AccountTextBox_TextChanged(object sender, EventArgs e)
        {
            string str = AccountTextBox.Text;
            if (str.Length > 0)
            {
                (accountDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("id LIKE '%{0}%' OR name LIKE '%{0}%'", str);
            }
            else
            {
                (accountDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
           
         
        }

        private void propertyTextBox_TextChanged(object sender, EventArgs e)
        {
            string str = propertyTextBox.Text;
            if (str.Length > 0)
            {
                (propertyDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("id LIKE '%{0}%' OR name LIKE '%{0}%'", str);
            }
            else
            {
                (propertyDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
      
        }

        private void viewTextBox_TextChanged(object sender, EventArgs e)
        {
            string str = viewTextBox.Text;
            if (str.Length > 0)
            {
                (GaViewDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("id LIKE '%{0}%' OR name LIKE '%{0}%'", str);
            }
            else
            {
                (GaViewDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
        }

       
      
    
    }
}
