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
        
        public Form1()
        {
            InitializeComponent();
            try
            {
                auth();
            }
            catch (AggregateException ex)
            {
                foreach (var ee in ex.InnerExceptions)
                {
                    MessageBox.Show(ee.Message);
                    //Console.WriteLine("ERROR: " + ee.Message);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            getMetaData();
        }

        private void auth()
        {
            
            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                           new ClientSecrets
                           {
                               ClientId = "643412917207.apps.googleusercontent.com",
                               ClientSecret = "NoEhLrjYIN10wIn41vUdCSB-"
                           },
                           new[] { AnalyticsService.Scope.AnalyticsReadonly },
                           "user", CancellationToken.None, new FileDataStore("ga")).Result;
             service = new AnalyticsService(
                new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "abc-analytics ga data exporter"
                });
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
                ListViewItem item = new ListViewItem(metric.Id.Replace("ga:", ""));
                item.ToolTipText = metric.Attributes["group"] + ":" + metric.Attributes["description"] + ":" + metric.Attributes["uiName"];
                listViewMetrics.Items.Add(item);
            }
            var dims = sitems.Where(c => c.Attributes["type"] == "DIMENSION").ToList();
            for (int k = 0; k < dims.Count; k++)
            {
                var dim = dims[k];
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
            getProperties();
        }
        private void getProperties()
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
            this.dataGridViewViews.DataSource = dt;
        }
        private void dataGridViewViews_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string aid = dataGridViewViews.Rows[e.RowIndex].Cells[3].Value.ToString();
            string wid = dataGridViewViews.Rows[e.RowIndex].Cells[4].Value.ToString();
            string vid = dataGridViewViews.Rows[e.RowIndex].Cells[0].Value.ToString();
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



        private void tmp(){
            /*
            DataResource.GaResource.GetRequest req = service.Data.Ga.Get("ga:" + id, "2014-10-01", "2014-10-03", "ga:sessions");
            req.MaxResults = 1000;
            req.Dimensions = "ga:deviceCategory";
            req.SamplingLevel = DataResource.GaResource.GetRequest.SamplingLevelEnum.DEFAULT;
            GaData ret = req.Execute();

            DataTable dt = new DataTable();
            IList<GaData.ColumnHeadersData> cols = ret.ColumnHeaders;
            foreach(GaData.ColumnHeadersData col in cols){
                if (col.DataType == "STRING")
                {
                    dt.Columns.Add(col.Name, typeof(string));
                }
                else
                {
                    dt.Columns.Add(col.Name, typeof(Int32));
                }
            }
            GaData.DataTableData data = ret.DataTable;
            for (int i = 0; i < ret.Rows.Count; i++)
            {
                DataRow row = dt.NewRow();
             
            }
             */

        }

        private void listViewMetrics_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var items = listViewMetrics.SelectedItems;
            string ret = "";
            foreach(ListViewItem item in items){
                ret += "ga:" + item.Text + ',';
            }
            textBoxMetrics.Text = ret.TrimEnd(',');
            this.labelMetrics.Text = "metrics\n(" + items.Count.ToString() + "/10)";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBoxMetrics.Clear();
            var items = this.listViewMetrics.SelectedItems;
            this.labelMetrics.Text = "metrics\n(0/10)";
            foreach(ListViewItem item in items){
                item.Selected = false;
            }
        }

        private void buttonClearDims_Click(object sender, EventArgs e)
        {
            this.textBoxDimensions.Clear();
            var items = this.listViewDimensions.SelectedItems;
            foreach (ListViewItem item in items)
            {
                item.Selected = false;
            }
        }

    
    }
}
