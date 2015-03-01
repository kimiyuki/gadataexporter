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
        private List<string> metricsItems = new List<string>();
        private List<string> dimensionsItems = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
            auth();
            getMetaData();
            startDateTextBox.Text = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
            endDateTextBox.Text = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
            indexTextBox.Text = "1";

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
            //dataGridViewAccount.Rows.Clear();
            //dataGridViewWebProperty.Rows.Clear();
            //GaViewdataGridView.Rows.Clear();
     
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
                metricsItems.Add(metric.Id.Replace("ga:",""));
                ListViewItem item = new ListViewItem(metric.Id.Replace("ga:", ""));
                item.ToolTipText = metric.Attributes["group"] + ":" + metric.Attributes["description"] + ":" + metric.Attributes["uiName"];
                listViewMetrics.Items.Add(item);
            }
            var dims = sitems.Where(c => c.Attributes["type"] == "DIMENSION").ToList();
            for (int k = 0; k < dims.Count; k++)
            {
                var dim = dims[k];
                dimensionsItems.Add(dim.Id.Replace("ga:",""));
                ListViewItem item = new ListViewItem(dim.Id.Replace("ga:", ""));
                item.ToolTipText = dim.Attributes["group"] + ":" + dim.Attributes["description"] + ":" + dim.Attributes["uiName"];
                listViewDimensions.Items.Add(item);
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
            this.dataGridViewAccount.DataSource = dt1;

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //IDを取得するので、cell[0]
            DataGridViewCell cell = (DataGridViewCell)dataGridViewAccount.Rows[e.RowIndex].Cells[0];
            string id = cell.Value.ToString();
            ManagementResource.WebpropertiesResource.ListRequest req = service.Management.Webproperties.List(id);
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
            this.dataGridViewWebProperty.DataSource = dt;
        }
        private void dataGridViewWebProperty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string wid =  dataGridViewWebProperty.Rows[e.RowIndex].Cells[0].Value.ToString();
            string aid = dataGridViewWebProperty.Rows[e.RowIndex].Cells[4].Value.ToString();
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
            this.GaViewdataGridView.DataSource = dt;
        }
        private void dataGridViewViews_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string aid = GaViewdataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            string wid = GaViewdataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            string vid = GaViewdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            ManagementResource.GoalsResource.ListRequest req = service.Management.Goals.List(aid, wid, vid);
            Goals ret = req.Execute();
            IList<Goal> goals = ret.Items;
           
            DataTable dt = new DataTable();
            dt.Columns.Add("no", typeof(string));
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("updated", typeof(string));
            dt.Columns.Add("value", typeof(string));
            dt.Columns.Add("active", typeof(string));
            dt.Columns.Add("type", typeof(string));
            if (goals != null)
            {
                for (int i = 0; i < goals.Count; i++)
                {
                    DataRow row = dt.NewRow();
                    row[0] = goals[i].Id;
                    row[1] = goals[i].Name;
                    row[2] = goals[i].Updated;
                    row[3] = goals[i].Value;
                    row[4] = goals[i].Active;
                    row[5] = goals[i].Type;
                    dt.Rows.Add(row);
                }
            }
            this.dataGridViewGoals.DataSource = dt;
        }

        private bool checkBeforeGetData(){
          
            var cells = GaViewdataGridView.SelectedCells;
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
        }

        private GaData getGaData(int max, int index)
        {
            string id = GaViewdataGridView.SelectedCells[0].Value.ToString();
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
                    if (col.DataType == "STRING")
                    {
                        dt.Columns.Add(col.Name.Replace("ga:", ""), typeof(string));
                    }
                    else if (col.DataType == "FLOAT" || col.DataType == "PERCENT")
                    {
                        dt.Columns.Add(col.Name.Replace("ga:", ""), typeof(float));
                    }
                    else
                    {
                        dt.Columns.Add(col.Name.Replace("ga:", ""), typeof(Int32));
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
            if (itemFilter.Text.Length < 2) {
                foreach (var m in metricsItems) { listViewMetrics.Items.Add(m); }
                foreach (var d in dimensionsItems) { listViewDimensions.Items.Add(d); }
                return;
            }

            //metrics
            List<string> metItems = new List<string>();
            foreach (ListViewItem i in listViewMetrics.SelectedItems) { metItems.Add(i.Text); }
            listViewMetrics.Items.Clear();
            foreach (string str in metItems)
            {
                listViewMetrics.Items.Add(str);
            }
            foreach(ListViewItem item in listViewMetrics.Items){
                item.Selected = true;
            }
            var ar = metricsItems.Where(i => i.ToLower().Contains(itemFilter.Text)).Select(c => new ListViewItem(c)).ToArray();
            foreach (var a in ar)
            {
                listViewMetrics.Items.Add(a.Text);
            }

            //dimensions
            List<string> dimItems = new List<string>();
            foreach (ListViewItem i in listViewDimensions.SelectedItems) { dimItems.Add(i.Text); }
            listViewDimensions.Items.Clear();
            foreach (string str in dimItems)
            {
                listViewDimensions.Items.Add(str);
            }
            foreach (ListViewItem item in listViewDimensions.Items)
            {
                item.Selected = true;
            }
            ar = dimensionsItems.Where(i => i.ToLower().Contains(itemFilter.Text)).Select(c => new ListViewItem(c)).ToArray();
            foreach(var a in ar){
                listViewDimensions.Items.Add(a.Text);
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

       
      
    
    }
}
