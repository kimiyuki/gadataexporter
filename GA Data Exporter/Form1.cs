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
                row[0] = metrics[k].Id;
                row[1] = metrics[k].Attributes["group"];
                row[2] = metrics[k].Attributes["uiName"];
                row[3] = metrics[k].Attributes["description"];
                dt.Rows.Add(row);
            }
            this.dataGridView1.DataSource = dt;

            DataTable dt1 = new DataTable();
            dt1.Columns.Add("id", typeof(string));
            dt1.Columns.Add("group", typeof(string));
            dt1.Columns.Add("ui name", typeof(string));
            dt1.Columns.Add("description", typeof(string));
            var dimensions = sitems.Where(c => c.Attributes["type"] == "DIMENSION").ToList();
            for (int k = 0; k < dimensions.Count; k++)
            {
                DataRow row = dt1.NewRow();
                row[0] = dimensions[k].Id;
                row[1] = dimensions[k].Attributes["group"];
                row[2] = dimensions[k].Attributes["uiName"];
                row[3] = dimensions[k].Attributes["description"];
                dt1.Rows.Add(row);
            }
            this.dataGridView2.DataSource = dt1;


        }

    }
}
