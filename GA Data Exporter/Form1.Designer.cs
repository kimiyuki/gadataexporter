namespace GA_Data_Exporter
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.gaDataGridViewData = new System.Windows.Forms.DataGridView();
            this.dataGridViewAccount = new System.Windows.Forms.DataGridView();
            this.buttonGetAuth = new System.Windows.Forms.Button();
            this.dataGridViewWebProperty = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewDimensions = new System.Windows.Forms.ListView();
            this.listViewMetrics = new System.Windows.Forms.ListView();
            this.dataGridViewDimMetrics = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewGoals = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.GaViewdataGridView = new System.Windows.Forms.DataGridView();
            this.buttonDeleteAuth = new System.Windows.Forms.Button();
            this.AuthChangeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.changePathAndSaveButton = new System.Windows.Forms.Button();
            this.queryTextBox = new System.Windows.Forms.TextBox();
            this.errorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.get1000 = new System.Windows.Forms.Button();
            this.getAll = new System.Windows.Forms.Button();
            this.metricsTextBox = new System.Windows.Forms.TextBox();
            this.dimensionsTextBox = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.itemFilter = new System.Windows.Forms.TextBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.buttonClearMerics = new System.Windows.Forms.Button();
            this.buttonClearDims = new System.Windows.Forms.Button();
            this.labelDimensions = new System.Windows.Forms.Label();
            this.labelMetrics = new System.Windows.Forms.Label();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.dateBetween = new System.Windows.Forms.Label();
            this.sortTextBox = new System.Windows.Forms.TextBox();
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.totalResultsNumtextBox = new System.Windows.Forms.TextBox();
            this.actualRowsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filterLinkLabel = new System.Windows.Forms.LinkLabel();
            this.sortLinkLabel = new System.Windows.Forms.LinkLabel();
            this.startLinkLabel = new System.Windows.Forms.LinkLabel();
            this.dateLinkLabel = new System.Windows.Forms.LinkLabel();
            this.segmentLinkLabel = new System.Windows.Forms.LinkLabel();
            this.metDimLabel = new System.Windows.Forms.Label();
            this.totalResultslabel = new System.Windows.Forms.Label();
            this.actualRowslabel = new System.Windows.Forms.Label();
            this.sampleLabel = new System.Windows.Forms.Label();
            this.sampleTextBox = new System.Windows.Forms.TextBox();
            this.accountLabel = new System.Windows.Forms.Label();
            this.propertyLabel = new System.Windows.Forms.Label();
            this.viewLabel = new System.Windows.Forms.Label();
            this.queryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gaDataGridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWebProperty)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDimMetrics)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GaViewdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(13, 96);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(263, 19);
            this.filePathTextBox.TabIndex = 1;
            // 
            // gaDataGridViewData
            // 
            this.gaDataGridViewData.AllowUserToAddRows = false;
            this.gaDataGridViewData.AllowUserToDeleteRows = false;
            this.gaDataGridViewData.AllowUserToOrderColumns = true;
            this.gaDataGridViewData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.gaDataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gaDataGridViewData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gaDataGridViewData.Location = new System.Drawing.Point(6, 6);
            this.gaDataGridViewData.Name = "gaDataGridViewData";
            this.gaDataGridViewData.RowTemplate.Height = 21;
            this.gaDataGridViewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gaDataGridViewData.Size = new System.Drawing.Size(892, 588);
            this.gaDataGridViewData.TabIndex = 2;
            // 
            // dataGridViewAccount
            // 
            this.dataGridViewAccount.AllowUserToAddRows = false;
            this.dataGridViewAccount.AllowUserToDeleteRows = false;
            this.dataGridViewAccount.AllowUserToOrderColumns = true;
            this.dataGridViewAccount.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridViewAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccount.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAccount.Location = new System.Drawing.Point(12, 228);
            this.dataGridViewAccount.Name = "dataGridViewAccount";
            this.dataGridViewAccount.RowTemplate.Height = 21;
            this.dataGridViewAccount.Size = new System.Drawing.Size(292, 99);
            this.dataGridViewAccount.TabIndex = 4;
            this.dataGridViewAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // buttonGetAuth
            // 
            this.buttonGetAuth.Location = new System.Drawing.Point(13, 176);
            this.buttonGetAuth.Name = "buttonGetAuth";
            this.buttonGetAuth.Size = new System.Drawing.Size(75, 23);
            this.buttonGetAuth.TabIndex = 5;
            this.buttonGetAuth.Text = "GetAuth";
            this.buttonGetAuth.UseVisualStyleBackColor = true;
            this.buttonGetAuth.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewWebProperty
            // 
            this.dataGridViewWebProperty.AllowUserToAddRows = false;
            this.dataGridViewWebProperty.AllowUserToDeleteRows = false;
            this.dataGridViewWebProperty.AllowUserToOrderColumns = true;
            this.dataGridViewWebProperty.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridViewWebProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWebProperty.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewWebProperty.Location = new System.Drawing.Point(13, 353);
            this.dataGridViewWebProperty.Name = "dataGridViewWebProperty";
            this.dataGridViewWebProperty.RowTemplate.Height = 21;
            this.dataGridViewWebProperty.Size = new System.Drawing.Size(292, 112);
            this.dataGridViewWebProperty.TabIndex = 6;
            this.dataGridViewWebProperty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWebProperty_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(311, 206);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(910, 646);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewDimensions);
            this.tabPage1.Controls.Add(this.listViewMetrics);
            this.tabPage1.Controls.Add(this.dataGridViewDimMetrics);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(902, 620);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DimMetrics";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewDimensions
            // 
            this.listViewDimensions.BackgroundImageTiled = true;
            this.listViewDimensions.GridLines = true;
            this.listViewDimensions.HideSelection = false;
            this.listViewDimensions.Location = new System.Drawing.Point(454, 10);
            this.listViewDimensions.Name = "listViewDimensions";
            this.listViewDimensions.ShowItemToolTips = true;
            this.listViewDimensions.Size = new System.Drawing.Size(445, 567);
            this.listViewDimensions.TabIndex = 5;
            this.listViewDimensions.TileSize = new System.Drawing.Size(141, 28);
            this.listViewDimensions.UseCompatibleStateImageBehavior = false;
            this.listViewDimensions.View = System.Windows.Forms.View.Tile;
            this.listViewDimensions.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewDimensions_ItemSelectionChanged);
            // 
            // listViewMetrics
            // 
            this.listViewMetrics.BackgroundImageTiled = true;
            this.listViewMetrics.FullRowSelect = true;
            this.listViewMetrics.GridLines = true;
            this.listViewMetrics.HideSelection = false;
            this.listViewMetrics.Location = new System.Drawing.Point(3, 10);
            this.listViewMetrics.Name = "listViewMetrics";
            this.listViewMetrics.ShowItemToolTips = true;
            this.listViewMetrics.Size = new System.Drawing.Size(447, 567);
            this.listViewMetrics.TabIndex = 4;
            this.listViewMetrics.TileSize = new System.Drawing.Size(141, 28);
            this.listViewMetrics.UseCompatibleStateImageBehavior = false;
            this.listViewMetrics.View = System.Windows.Forms.View.Tile;
            this.listViewMetrics.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewMetrics_ItemSelectionChanged);
            // 
            // dataGridViewDimMetrics
            // 
            this.dataGridViewDimMetrics.AllowUserToAddRows = false;
            this.dataGridViewDimMetrics.AllowUserToDeleteRows = false;
            this.dataGridViewDimMetrics.AllowUserToOrderColumns = true;
            this.dataGridViewDimMetrics.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridViewDimMetrics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDimMetrics.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDimMetrics.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewDimMetrics.Location = new System.Drawing.Point(-6, -25);
            this.dataGridViewDimMetrics.Name = "dataGridViewDimMetrics";
            this.dataGridViewDimMetrics.RowTemplate.Height = 21;
            this.dataGridViewDimMetrics.Size = new System.Drawing.Size(912, 609);
            this.dataGridViewDimMetrics.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gaDataGridViewData);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(902, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewGoals);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(902, 620);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Goals";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGoals
            // 
            this.dataGridViewGoals.AllowUserToAddRows = false;
            this.dataGridViewGoals.AllowUserToDeleteRows = false;
            this.dataGridViewGoals.AllowUserToOrderColumns = true;
            this.dataGridViewGoals.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridViewGoals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGoals.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewGoals.Location = new System.Drawing.Point(0, 6);
            this.dataGridViewGoals.Name = "dataGridViewGoals";
            this.dataGridViewGoals.RowTemplate.Height = 21;
            this.dataGridViewGoals.Size = new System.Drawing.Size(831, 582);
            this.dataGridViewGoals.TabIndex = 9;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(902, 620);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ViewDetails";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(902, 620);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Filters";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(902, 620);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Segments";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(902, 620);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "MCF";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // GaViewdataGridView
            // 
            this.GaViewdataGridView.AllowUserToAddRows = false;
            this.GaViewdataGridView.AllowUserToDeleteRows = false;
            this.GaViewdataGridView.AllowUserToOrderColumns = true;
            this.GaViewdataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.GaViewdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GaViewdataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GaViewdataGridView.Location = new System.Drawing.Point(13, 492);
            this.GaViewdataGridView.Name = "GaViewdataGridView";
            this.GaViewdataGridView.RowTemplate.Height = 21;
            this.GaViewdataGridView.Size = new System.Drawing.Size(291, 320);
            this.GaViewdataGridView.TabIndex = 8;
            this.GaViewdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewViews_CellClick);
            // 
            // buttonDeleteAuth
            // 
            this.buttonDeleteAuth.Location = new System.Drawing.Point(106, 176);
            this.buttonDeleteAuth.Name = "buttonDeleteAuth";
            this.buttonDeleteAuth.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAuth.TabIndex = 9;
            this.buttonDeleteAuth.Text = "DeleteAuth";
            this.buttonDeleteAuth.UseVisualStyleBackColor = true;
            this.buttonDeleteAuth.Click += new System.EventHandler(this.buttonDeleteAuth_Click);
            // 
            // AuthChangeButton
            // 
            this.AuthChangeButton.Location = new System.Drawing.Point(201, 176);
            this.AuthChangeButton.Name = "AuthChangeButton";
            this.AuthChangeButton.Size = new System.Drawing.Size(75, 23);
            this.AuthChangeButton.TabIndex = 10;
            this.AuthChangeButton.Text = "changeAuth";
            this.AuthChangeButton.UseVisualStyleBackColor = true;
            this.AuthChangeButton.Click += new System.EventHandler(this.AuthChangeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(14, 121);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(103, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "simpleSave";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // changePathAndSaveButton
            // 
            this.changePathAndSaveButton.Location = new System.Drawing.Point(138, 121);
            this.changePathAndSaveButton.Name = "changePathAndSaveButton";
            this.changePathAndSaveButton.Size = new System.Drawing.Size(135, 23);
            this.changePathAndSaveButton.TabIndex = 12;
            this.changePathAndSaveButton.Text = "change Path and Save";
            this.changePathAndSaveButton.UseVisualStyleBackColor = true;
            this.changePathAndSaveButton.Click += new System.EventHandler(this.changePathAndSaveButton_Click);
            // 
            // queryTextBox
            // 
            this.queryTextBox.Location = new System.Drawing.Point(79, 12);
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(1096, 19);
            this.queryTextBox.TabIndex = 13;
            // 
            // errorTextBox
            // 
            this.errorTextBox.Location = new System.Drawing.Point(79, 37);
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.Size = new System.Drawing.Size(1098, 19);
            this.errorTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "Error";
            // 
            // get1000
            // 
            this.get1000.Location = new System.Drawing.Point(311, 64);
            this.get1000.Name = "get1000";
            this.get1000.Size = new System.Drawing.Size(75, 40);
            this.get1000.TabIndex = 17;
            this.get1000.Text = "Get 1000";
            this.get1000.UseVisualStyleBackColor = true;
            this.get1000.Click += new System.EventHandler(this.get1000_Click);
            // 
            // getAll
            // 
            this.getAll.Location = new System.Drawing.Point(311, 110);
            this.getAll.Name = "getAll";
            this.getAll.Size = new System.Drawing.Size(75, 38);
            this.getAll.TabIndex = 18;
            this.getAll.Text = "Get All";
            this.getAll.UseVisualStyleBackColor = true;
            this.getAll.Click += new System.EventHandler(this.getAll_Click);
            // 
            // metricsTextBox
            // 
            this.metricsTextBox.Location = new System.Drawing.Point(481, 64);
            this.metricsTextBox.Name = "metricsTextBox";
            this.metricsTextBox.Size = new System.Drawing.Size(702, 19);
            this.metricsTextBox.TabIndex = 19;
            // 
            // dimensionsTextBox
            // 
            this.dimensionsTextBox.Location = new System.Drawing.Point(481, 89);
            this.dimensionsTextBox.Name = "dimensionsTextBox";
            this.dimensionsTextBox.Size = new System.Drawing.Size(702, 19);
            this.dimensionsTextBox.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(481, 114);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(702, 19);
            this.textBox6.TabIndex = 21;
            // 
            // itemFilter
            // 
            this.itemFilter.Location = new System.Drawing.Point(310, 178);
            this.itemFilter.Name = "itemFilter";
            this.itemFilter.Size = new System.Drawing.Size(94, 19);
            this.itemFilter.TabIndex = 22;
            this.itemFilter.TextChanged += new System.EventHandler(this.itemFilter_TextChanged);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(694, 135);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(174, 19);
            this.filterTextBox.TabIndex = 23;
            // 
            // buttonClearMerics
            // 
            this.buttonClearMerics.Location = new System.Drawing.Point(446, 62);
            this.buttonClearMerics.Name = "buttonClearMerics";
            this.buttonClearMerics.Size = new System.Drawing.Size(29, 23);
            this.buttonClearMerics.TabIndex = 24;
            this.buttonClearMerics.Text = "C";
            this.buttonClearMerics.UseVisualStyleBackColor = true;
            this.buttonClearMerics.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonClearDims
            // 
            this.buttonClearDims.Location = new System.Drawing.Point(446, 89);
            this.buttonClearDims.Name = "buttonClearDims";
            this.buttonClearDims.Size = new System.Drawing.Size(29, 23);
            this.buttonClearDims.TabIndex = 25;
            this.buttonClearDims.Text = "C";
            this.buttonClearDims.UseVisualStyleBackColor = true;
            this.buttonClearDims.Click += new System.EventHandler(this.buttonClearDims_Click);
            // 
            // labelDimensions
            // 
            this.labelDimensions.AutoSize = true;
            this.labelDimensions.Location = new System.Drawing.Point(392, 92);
            this.labelDimensions.Name = "labelDimensions";
            this.labelDimensions.Size = new System.Drawing.Size(31, 24);
            this.labelDimensions.TabIndex = 26;
            this.labelDimensions.Text = "Dims\r\n(0/7)";
            // 
            // labelMetrics
            // 
            this.labelMetrics.AutoSize = true;
            this.labelMetrics.Location = new System.Drawing.Point(392, 64);
            this.labelMetrics.Name = "labelMetrics";
            this.labelMetrics.Size = new System.Drawing.Size(43, 24);
            this.labelMetrics.TabIndex = 27;
            this.labelMetrics.Text = "Metrics\r\n(0/10)";
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Location = new System.Drawing.Point(552, 136);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(86, 19);
            this.endDateTextBox.TabIndex = 28;
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(443, 136);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(95, 19);
            this.startDateTextBox.TabIndex = 29;
            // 
            // dateBetween
            // 
            this.dateBetween.AutoSize = true;
            this.dateBetween.Location = new System.Drawing.Point(540, 139);
            this.dateBetween.Name = "dateBetween";
            this.dateBetween.Size = new System.Drawing.Size(11, 12);
            this.dateBetween.TabIndex = 31;
            this.dateBetween.Text = "-";
            // 
            // sortTextBox
            // 
            this.sortTextBox.Location = new System.Drawing.Point(907, 134);
            this.sortTextBox.Name = "sortTextBox";
            this.sortTextBox.Size = new System.Drawing.Size(174, 19);
            this.sortTextBox.TabIndex = 33;
            // 
            // indexTextBox
            // 
            this.indexTextBox.Location = new System.Drawing.Point(1114, 134);
            this.indexTextBox.Name = "indexTextBox";
            this.indexTextBox.Size = new System.Drawing.Size(69, 19);
            this.indexTextBox.TabIndex = 34;
            // 
            // totalResultsNumtextBox
            // 
            this.totalResultsNumtextBox.Location = new System.Drawing.Point(408, 178);
            this.totalResultsNumtextBox.Name = "totalResultsNumtextBox";
            this.totalResultsNumtextBox.Size = new System.Drawing.Size(75, 19);
            this.totalResultsNumtextBox.TabIndex = 38;
            // 
            // actualRowsTextBox
            // 
            this.actualRowsTextBox.Location = new System.Drawing.Point(491, 178);
            this.actualRowsTextBox.Name = "actualRowsTextBox";
            this.actualRowsTextBox.Size = new System.Drawing.Size(75, 19);
            this.actualRowsTextBox.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 12);
            this.label3.TabIndex = 40;
            this.label3.Text = "DownLoad Path";
            // 
            // filterLinkLabel
            // 
            this.filterLinkLabel.AutoSize = true;
            this.filterLinkLabel.Location = new System.Drawing.Point(660, 138);
            this.filterLinkLabel.Name = "filterLinkLabel";
            this.filterLinkLabel.Size = new System.Drawing.Size(25, 12);
            this.filterLinkLabel.TabIndex = 41;
            this.filterLinkLabel.TabStop = true;
            this.filterLinkLabel.Text = "filer";
            this.filterLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.filterLinkLabel_LinkClicked);
            // 
            // sortLinkLabel
            // 
            this.sortLinkLabel.AutoSize = true;
            this.sortLinkLabel.Location = new System.Drawing.Point(874, 138);
            this.sortLinkLabel.Name = "sortLinkLabel";
            this.sortLinkLabel.Size = new System.Drawing.Size(25, 12);
            this.sortLinkLabel.TabIndex = 42;
            this.sortLinkLabel.TabStop = true;
            this.sortLinkLabel.Text = "sort";
            this.sortLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sortLinkLabel_LinkClicked);
            // 
            // startLinkLabel
            // 
            this.startLinkLabel.AutoSize = true;
            this.startLinkLabel.Location = new System.Drawing.Point(1083, 138);
            this.startLinkLabel.Name = "startLinkLabel";
            this.startLinkLabel.Size = new System.Drawing.Size(29, 12);
            this.startLinkLabel.TabIndex = 43;
            this.startLinkLabel.TabStop = true;
            this.startLinkLabel.Text = "start";
            this.startLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.startLinkLabel_LinkClicked);
            // 
            // dateLinkLabel
            // 
            this.dateLinkLabel.AutoSize = true;
            this.dateLinkLabel.Location = new System.Drawing.Point(394, 139);
            this.dateLinkLabel.Name = "dateLinkLabel";
            this.dateLinkLabel.Size = new System.Drawing.Size(27, 12);
            this.dateLinkLabel.TabIndex = 44;
            this.dateLinkLabel.TabStop = true;
            this.dateLinkLabel.Text = "date";
            this.dateLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dateLinkLabel_LinkClicked);
            // 
            // segmentLinkLabel
            // 
            this.segmentLinkLabel.AutoSize = true;
            this.segmentLinkLabel.Location = new System.Drawing.Point(393, 121);
            this.segmentLinkLabel.Name = "segmentLinkLabel";
            this.segmentLinkLabel.Size = new System.Drawing.Size(48, 12);
            this.segmentLinkLabel.TabIndex = 45;
            this.segmentLinkLabel.TabStop = true;
            this.segmentLinkLabel.Text = "segment";
            this.segmentLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.segmentLinkLabel_LinkClicked);
            // 
            // metDimLabel
            // 
            this.metDimLabel.AutoSize = true;
            this.metDimLabel.Location = new System.Drawing.Point(308, 163);
            this.metDimLabel.Name = "metDimLabel";
            this.metDimLabel.Size = new System.Drawing.Size(90, 12);
            this.metDimLabel.TabIndex = 46;
            this.metDimLabel.Text = "metricsDimFilter";
            // 
            // totalResultslabel
            // 
            this.totalResultslabel.AutoSize = true;
            this.totalResultslabel.Location = new System.Drawing.Point(408, 163);
            this.totalResultslabel.Name = "totalResultslabel";
            this.totalResultslabel.Size = new System.Drawing.Size(67, 12);
            this.totalResultslabel.TabIndex = 47;
            this.totalResultslabel.Text = "totalResults";
            // 
            // actualRowslabel
            // 
            this.actualRowslabel.AutoSize = true;
            this.actualRowslabel.Location = new System.Drawing.Point(489, 163);
            this.actualRowslabel.Name = "actualRowslabel";
            this.actualRowslabel.Size = new System.Drawing.Size(64, 12);
            this.actualRowslabel.TabIndex = 48;
            this.actualRowslabel.Text = "actualRows";
            // 
            // sampleLabel
            // 
            this.sampleLabel.AutoSize = true;
            this.sampleLabel.Location = new System.Drawing.Point(575, 163);
            this.sampleLabel.Name = "sampleLabel";
            this.sampleLabel.Size = new System.Drawing.Size(46, 12);
            this.sampleLabel.TabIndex = 50;
            this.sampleLabel.Text = "sample?";
            // 
            // sampleTextBox
            // 
            this.sampleTextBox.Location = new System.Drawing.Point(577, 178);
            this.sampleTextBox.Name = "sampleTextBox";
            this.sampleTextBox.Size = new System.Drawing.Size(108, 19);
            this.sampleTextBox.TabIndex = 49;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(12, 212);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(114, 12);
            this.accountLabel.TabIndex = 51;
            this.accountLabel.Text = "Account : SELECT ID";
            // 
            // propertyLabel
            // 
            this.propertyLabel.AutoSize = true;
            this.propertyLabel.Location = new System.Drawing.Point(12, 338);
            this.propertyLabel.Name = "propertyLabel";
            this.propertyLabel.Size = new System.Drawing.Size(115, 12);
            this.propertyLabel.TabIndex = 52;
            this.propertyLabel.Text = "Property : SELECT ID";
            // 
            // viewLabel
            // 
            this.viewLabel.AutoSize = true;
            this.viewLabel.Location = new System.Drawing.Point(11, 477);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(97, 12);
            this.viewLabel.TabIndex = 53;
            this.viewLabel.Text = "View : SELECT ID";
            // 
            // queryLinkLabel
            // 
            this.queryLinkLabel.AutoSize = true;
            this.queryLinkLabel.Location = new System.Drawing.Point(27, 15);
            this.queryLinkLabel.Name = "queryLinkLabel";
            this.queryLinkLabel.Size = new System.Drawing.Size(35, 12);
            this.queryLinkLabel.TabIndex = 54;
            this.queryLinkLabel.TabStop = true;
            this.queryLinkLabel.Text = "Query";
            this.queryLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.queryLinkLabel_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1225, 24);
            this.menuStrip1.TabIndex = 55;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1225, 819);
            this.Controls.Add(this.queryLinkLabel);
            this.Controls.Add(this.viewLabel);
            this.Controls.Add(this.propertyLabel);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.sampleLabel);
            this.Controls.Add(this.sampleTextBox);
            this.Controls.Add(this.actualRowslabel);
            this.Controls.Add(this.totalResultslabel);
            this.Controls.Add(this.metDimLabel);
            this.Controls.Add(this.segmentLinkLabel);
            this.Controls.Add(this.dateLinkLabel);
            this.Controls.Add(this.startLinkLabel);
            this.Controls.Add(this.sortLinkLabel);
            this.Controls.Add(this.filterLinkLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.actualRowsTextBox);
            this.Controls.Add(this.totalResultsNumtextBox);
            this.Controls.Add(this.indexTextBox);
            this.Controls.Add(this.sortTextBox);
            this.Controls.Add(this.dateBetween);
            this.Controls.Add(this.startDateTextBox);
            this.Controls.Add(this.endDateTextBox);
            this.Controls.Add(this.labelMetrics);
            this.Controls.Add(this.labelDimensions);
            this.Controls.Add(this.buttonClearDims);
            this.Controls.Add(this.buttonClearMerics);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.itemFilter);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.dimensionsTextBox);
            this.Controls.Add(this.metricsTextBox);
            this.Controls.Add(this.getAll);
            this.Controls.Add(this.get1000);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorTextBox);
            this.Controls.Add(this.queryTextBox);
            this.Controls.Add(this.changePathAndSaveButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.AuthChangeButton);
            this.Controls.Add(this.buttonDeleteAuth);
            this.Controls.Add(this.GaViewdataGridView);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridViewWebProperty);
            this.Controls.Add(this.buttonGetAuth);
            this.Controls.Add(this.dataGridViewAccount);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Google Analytics Data Exporter";
            ((System.ComponentModel.ISupportInitialize)(this.gaDataGridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWebProperty)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDimMetrics)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GaViewdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.DataGridView gaDataGridViewData;
        private System.Windows.Forms.DataGridView dataGridViewAccount;
        private System.Windows.Forms.Button buttonGetAuth;
        private System.Windows.Forms.DataGridView dataGridViewWebProperty;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewDimMetrics;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView GaViewdataGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewGoals;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.ListView listViewMetrics;
        private System.Windows.Forms.ListView listViewDimensions;
        private System.Windows.Forms.Button buttonDeleteAuth;
        private System.Windows.Forms.Button AuthChangeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button changePathAndSaveButton;
        private System.Windows.Forms.TextBox queryTextBox;
        private System.Windows.Forms.TextBox errorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button get1000;
        private System.Windows.Forms.Button getAll;
        private System.Windows.Forms.TextBox metricsTextBox;
        private System.Windows.Forms.TextBox dimensionsTextBox;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox itemFilter;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Button buttonClearMerics;
        private System.Windows.Forms.Button buttonClearDims;
        private System.Windows.Forms.Label labelDimensions;
        private System.Windows.Forms.Label labelMetrics;
        private System.Windows.Forms.TextBox endDateTextBox;
        private System.Windows.Forms.TextBox startDateTextBox;
        private System.Windows.Forms.Label dateBetween;
        private System.Windows.Forms.TextBox sortTextBox;
        private System.Windows.Forms.TextBox indexTextBox;
        private System.Windows.Forms.TextBox totalResultsNumtextBox;
        private System.Windows.Forms.TextBox actualRowsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel filterLinkLabel;
        private System.Windows.Forms.LinkLabel sortLinkLabel;
        private System.Windows.Forms.LinkLabel startLinkLabel;
        private System.Windows.Forms.LinkLabel dateLinkLabel;
        private System.Windows.Forms.LinkLabel segmentLinkLabel;
        private System.Windows.Forms.Label metDimLabel;
        private System.Windows.Forms.Label totalResultslabel;
        private System.Windows.Forms.Label actualRowslabel;
        private System.Windows.Forms.Label sampleLabel;
        private System.Windows.Forms.TextBox sampleTextBox;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Label propertyLabel;
        private System.Windows.Forms.Label viewLabel;
        private System.Windows.Forms.LinkLabel queryLinkLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

