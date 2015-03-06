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
            this.accountDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonGetAuth = new System.Windows.Forms.Button();
            this.propertyDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewDimensions = new System.Windows.Forms.ListView();
            this.listViewMetrics = new System.Windows.Forms.ListView();
            this.dataGridViewDimMetrics = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.goalDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.viewDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.segmentDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.GaViewDataGridView = new System.Windows.Forms.DataGridView();
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
            this.segmentTextBox = new System.Windows.Forms.TextBox();
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
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.AccountTextBox = new System.Windows.Forms.TextBox();
            this.propertyTextBox = new System.Windows.Forms.TextBox();
            this.viewTextBox = new System.Windows.Forms.TextBox();
            this.queryHistoryMenuStrip = new System.Windows.Forms.MenuStrip();
            this.queryHistoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gaDataGridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDimMetrics)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goalDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewDetailDataGridView)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.segmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GaViewDataGridView)).BeginInit();
            this.queryHistoryMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(13, 118);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(263, 19);
            this.filePathTextBox.TabIndex = 1;
            // 
            // gaDataGridViewData
            // 
            this.gaDataGridViewData.AllowUserToAddRows = false;
            this.gaDataGridViewData.AllowUserToDeleteRows = false;
            this.gaDataGridViewData.AllowUserToOrderColumns = true;
            this.gaDataGridViewData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // accountDataGridView
            // 
            this.accountDataGridView.AllowUserToAddRows = false;
            this.accountDataGridView.AllowUserToDeleteRows = false;
            this.accountDataGridView.AllowUserToOrderColumns = true;
            this.accountDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.accountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.accountDataGridView.Location = new System.Drawing.Point(12, 250);
            this.accountDataGridView.Name = "accountDataGridView";
            this.accountDataGridView.RowTemplate.Height = 21;
            this.accountDataGridView.Size = new System.Drawing.Size(292, 99);
            this.accountDataGridView.TabIndex = 4;
            this.accountDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // buttonGetAuth
            // 
            this.buttonGetAuth.Location = new System.Drawing.Point(13, 198);
            this.buttonGetAuth.Name = "buttonGetAuth";
            this.buttonGetAuth.Size = new System.Drawing.Size(75, 23);
            this.buttonGetAuth.TabIndex = 5;
            this.buttonGetAuth.Text = "GetAuth";
            this.buttonGetAuth.UseVisualStyleBackColor = true;
            this.buttonGetAuth.Click += new System.EventHandler(this.button2_Click);
            // 
            // propertyDataGridView
            // 
            this.propertyDataGridView.AllowUserToAddRows = false;
            this.propertyDataGridView.AllowUserToDeleteRows = false;
            this.propertyDataGridView.AllowUserToOrderColumns = true;
            this.propertyDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.propertyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertyDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.propertyDataGridView.Location = new System.Drawing.Point(13, 375);
            this.propertyDataGridView.Name = "propertyDataGridView";
            this.propertyDataGridView.RowTemplate.Height = 21;
            this.propertyDataGridView.Size = new System.Drawing.Size(292, 112);
            this.propertyDataGridView.TabIndex = 6;
            this.propertyDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWebProperty_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(311, 228);
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
            this.listViewDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDimensions.BackgroundImageTiled = true;
            this.listViewDimensions.GridLines = true;
            this.listViewDimensions.HideSelection = false;
            this.listViewDimensions.Location = new System.Drawing.Point(454, 6);
            this.listViewDimensions.Name = "listViewDimensions";
            this.listViewDimensions.ShowItemToolTips = true;
            this.listViewDimensions.Size = new System.Drawing.Size(445, 593);
            this.listViewDimensions.TabIndex = 5;
            this.listViewDimensions.TileSize = new System.Drawing.Size(141, 28);
            this.listViewDimensions.UseCompatibleStateImageBehavior = false;
            this.listViewDimensions.View = System.Windows.Forms.View.Tile;
            this.listViewDimensions.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewDimensions_ItemSelectionChanged);
            // 
            // listViewMetrics
            // 
            this.listViewMetrics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMetrics.BackgroundImageTiled = true;
            this.listViewMetrics.FullRowSelect = true;
            this.listViewMetrics.GridLines = true;
            this.listViewMetrics.HideSelection = false;
            this.listViewMetrics.Location = new System.Drawing.Point(3, 6);
            this.listViewMetrics.Name = "listViewMetrics";
            this.listViewMetrics.ShowItemToolTips = true;
            this.listViewMetrics.Size = new System.Drawing.Size(447, 593);
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
            this.dataGridViewDimMetrics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDimMetrics.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridViewDimMetrics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDimMetrics.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDimMetrics.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewDimMetrics.Location = new System.Drawing.Point(-6, -3);
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
            this.tabPage3.Controls.Add(this.goalDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(902, 620);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Goals";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // goalDataGridView
            // 
            this.goalDataGridView.AllowUserToAddRows = false;
            this.goalDataGridView.AllowUserToDeleteRows = false;
            this.goalDataGridView.AllowUserToOrderColumns = true;
            this.goalDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goalDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.goalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goalDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.goalDataGridView.Location = new System.Drawing.Point(2, 6);
            this.goalDataGridView.Name = "goalDataGridView";
            this.goalDataGridView.RowTemplate.Height = 21;
            this.goalDataGridView.Size = new System.Drawing.Size(896, 603);
            this.goalDataGridView.TabIndex = 9;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.viewDetailDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(902, 620);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ViewDetails";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // viewDetailDataGridView
            // 
            this.viewDetailDataGridView.AllowUserToAddRows = false;
            this.viewDetailDataGridView.AllowUserToDeleteRows = false;
            this.viewDetailDataGridView.AllowUserToOrderColumns = true;
            this.viewDetailDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.viewDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewDetailDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewDetailDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.viewDetailDataGridView.Location = new System.Drawing.Point(3, 25);
            this.viewDetailDataGridView.Name = "viewDetailDataGridView";
            this.viewDetailDataGridView.RowHeadersWidth = 150;
            this.viewDetailDataGridView.RowTemplate.Height = 21;
            this.viewDetailDataGridView.Size = new System.Drawing.Size(896, 582);
            this.viewDetailDataGridView.TabIndex = 10;
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
            this.tabPage6.Controls.Add(this.segmentDataGridView);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(902, 620);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Segments";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // segmentDataGridView
            // 
            this.segmentDataGridView.AllowUserToAddRows = false;
            this.segmentDataGridView.AllowUserToDeleteRows = false;
            this.segmentDataGridView.AllowUserToOrderColumns = true;
            this.segmentDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.segmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.segmentDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.segmentDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.segmentDataGridView.Location = new System.Drawing.Point(3, 27);
            this.segmentDataGridView.Name = "segmentDataGridView";
            this.segmentDataGridView.RowHeadersWidth = 10;
            this.segmentDataGridView.RowTemplate.Height = 21;
            this.segmentDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.segmentDataGridView.Size = new System.Drawing.Size(896, 582);
            this.segmentDataGridView.TabIndex = 11;
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
            // GaViewDataGridView
            // 
            this.GaViewDataGridView.AllowUserToAddRows = false;
            this.GaViewDataGridView.AllowUserToDeleteRows = false;
            this.GaViewDataGridView.AllowUserToOrderColumns = true;
            this.GaViewDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.GaViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GaViewDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GaViewDataGridView.Location = new System.Drawing.Point(13, 514);
            this.GaViewDataGridView.Name = "GaViewDataGridView";
            this.GaViewDataGridView.RowTemplate.Height = 21;
            this.GaViewDataGridView.Size = new System.Drawing.Size(291, 320);
            this.GaViewDataGridView.TabIndex = 8;
            this.GaViewDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewViews_CellClick);
            // 
            // buttonDeleteAuth
            // 
            this.buttonDeleteAuth.Location = new System.Drawing.Point(106, 198);
            this.buttonDeleteAuth.Name = "buttonDeleteAuth";
            this.buttonDeleteAuth.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAuth.TabIndex = 9;
            this.buttonDeleteAuth.Text = "DeleteAuth";
            this.buttonDeleteAuth.UseVisualStyleBackColor = true;
            this.buttonDeleteAuth.Click += new System.EventHandler(this.buttonDeleteAuth_Click);
            // 
            // AuthChangeButton
            // 
            this.AuthChangeButton.Location = new System.Drawing.Point(201, 198);
            this.AuthChangeButton.Name = "AuthChangeButton";
            this.AuthChangeButton.Size = new System.Drawing.Size(75, 23);
            this.AuthChangeButton.TabIndex = 10;
            this.AuthChangeButton.Text = "changeAuth";
            this.AuthChangeButton.UseVisualStyleBackColor = true;
            this.AuthChangeButton.Click += new System.EventHandler(this.AuthChangeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(14, 143);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(103, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "simpleSave";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // changePathAndSaveButton
            // 
            this.changePathAndSaveButton.Location = new System.Drawing.Point(138, 143);
            this.changePathAndSaveButton.Name = "changePathAndSaveButton";
            this.changePathAndSaveButton.Size = new System.Drawing.Size(135, 23);
            this.changePathAndSaveButton.TabIndex = 12;
            this.changePathAndSaveButton.Text = "change Path and Save";
            this.changePathAndSaveButton.UseVisualStyleBackColor = true;
            this.changePathAndSaveButton.Click += new System.EventHandler(this.changePathAndSaveButton_Click);
            // 
            // queryTextBox
            // 
            this.queryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryTextBox.Location = new System.Drawing.Point(79, 34);
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(1124, 19);
            this.queryTextBox.TabIndex = 13;
            // 
            // errorTextBox
            // 
            this.errorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorTextBox.ForeColor = System.Drawing.Color.Red;
            this.errorTextBox.Location = new System.Drawing.Point(79, 59);
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.Size = new System.Drawing.Size(1124, 19);
            this.errorTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "Error";
            // 
            // get1000
            // 
            this.get1000.Location = new System.Drawing.Point(311, 86);
            this.get1000.Name = "get1000";
            this.get1000.Size = new System.Drawing.Size(75, 40);
            this.get1000.TabIndex = 17;
            this.get1000.Text = "Get 1000";
            this.get1000.UseVisualStyleBackColor = true;
            this.get1000.Click += new System.EventHandler(this.get1000_Click);
            // 
            // getAll
            // 
            this.getAll.Location = new System.Drawing.Point(311, 132);
            this.getAll.Name = "getAll";
            this.getAll.Size = new System.Drawing.Size(75, 38);
            this.getAll.TabIndex = 18;
            this.getAll.Text = "Get All";
            this.getAll.UseVisualStyleBackColor = true;
            this.getAll.Click += new System.EventHandler(this.getAll_Click);
            // 
            // metricsTextBox
            // 
            this.metricsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metricsTextBox.Location = new System.Drawing.Point(481, 86);
            this.metricsTextBox.Name = "metricsTextBox";
            this.metricsTextBox.Size = new System.Drawing.Size(722, 19);
            this.metricsTextBox.TabIndex = 19;
            // 
            // dimensionsTextBox
            // 
            this.dimensionsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dimensionsTextBox.Location = new System.Drawing.Point(481, 111);
            this.dimensionsTextBox.Name = "dimensionsTextBox";
            this.dimensionsTextBox.Size = new System.Drawing.Size(722, 19);
            this.dimensionsTextBox.TabIndex = 20;
            // 
            // segmentTextBox
            // 
            this.segmentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.segmentTextBox.Location = new System.Drawing.Point(481, 136);
            this.segmentTextBox.Name = "segmentTextBox";
            this.segmentTextBox.Size = new System.Drawing.Size(722, 19);
            this.segmentTextBox.TabIndex = 21;
            // 
            // itemFilter
            // 
            this.itemFilter.Location = new System.Drawing.Point(430, 200);
            this.itemFilter.Name = "itemFilter";
            this.itemFilter.Size = new System.Drawing.Size(94, 19);
            this.itemFilter.TabIndex = 22;
            this.itemFilter.TextChanged += new System.EventHandler(this.itemFilter_TextChanged);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(694, 157);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(174, 19);
            this.filterTextBox.TabIndex = 23;
            // 
            // buttonClearMerics
            // 
            this.buttonClearMerics.Location = new System.Drawing.Point(446, 84);
            this.buttonClearMerics.Name = "buttonClearMerics";
            this.buttonClearMerics.Size = new System.Drawing.Size(29, 23);
            this.buttonClearMerics.TabIndex = 24;
            this.buttonClearMerics.Text = "C";
            this.buttonClearMerics.UseVisualStyleBackColor = true;
            this.buttonClearMerics.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonClearDims
            // 
            this.buttonClearDims.Location = new System.Drawing.Point(446, 111);
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
            this.labelDimensions.Location = new System.Drawing.Point(392, 114);
            this.labelDimensions.Name = "labelDimensions";
            this.labelDimensions.Size = new System.Drawing.Size(31, 24);
            this.labelDimensions.TabIndex = 26;
            this.labelDimensions.Text = "Dims\r\n(0/7)";
            // 
            // labelMetrics
            // 
            this.labelMetrics.AutoSize = true;
            this.labelMetrics.Location = new System.Drawing.Point(392, 86);
            this.labelMetrics.Name = "labelMetrics";
            this.labelMetrics.Size = new System.Drawing.Size(43, 24);
            this.labelMetrics.TabIndex = 27;
            this.labelMetrics.Text = "Metrics\r\n(0/10)";
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Location = new System.Drawing.Point(552, 158);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(86, 19);
            this.endDateTextBox.TabIndex = 28;
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(443, 158);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(95, 19);
            this.startDateTextBox.TabIndex = 29;
            // 
            // dateBetween
            // 
            this.dateBetween.AutoSize = true;
            this.dateBetween.Location = new System.Drawing.Point(540, 161);
            this.dateBetween.Name = "dateBetween";
            this.dateBetween.Size = new System.Drawing.Size(11, 12);
            this.dateBetween.TabIndex = 31;
            this.dateBetween.Text = "-";
            // 
            // sortTextBox
            // 
            this.sortTextBox.Location = new System.Drawing.Point(907, 156);
            this.sortTextBox.Name = "sortTextBox";
            this.sortTextBox.Size = new System.Drawing.Size(174, 19);
            this.sortTextBox.TabIndex = 33;
            // 
            // indexTextBox
            // 
            this.indexTextBox.Location = new System.Drawing.Point(1134, 156);
            this.indexTextBox.Name = "indexTextBox";
            this.indexTextBox.Size = new System.Drawing.Size(69, 19);
            this.indexTextBox.TabIndex = 34;
            // 
            // totalResultsNumtextBox
            // 
            this.totalResultsNumtextBox.Location = new System.Drawing.Point(528, 200);
            this.totalResultsNumtextBox.Name = "totalResultsNumtextBox";
            this.totalResultsNumtextBox.Size = new System.Drawing.Size(75, 19);
            this.totalResultsNumtextBox.TabIndex = 38;
            // 
            // actualRowsTextBox
            // 
            this.actualRowsTextBox.Location = new System.Drawing.Point(611, 200);
            this.actualRowsTextBox.Name = "actualRowsTextBox";
            this.actualRowsTextBox.Size = new System.Drawing.Size(75, 19);
            this.actualRowsTextBox.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 12);
            this.label3.TabIndex = 40;
            this.label3.Text = "DownLoad Path";
            // 
            // filterLinkLabel
            // 
            this.filterLinkLabel.AutoSize = true;
            this.filterLinkLabel.Location = new System.Drawing.Point(660, 160);
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
            this.sortLinkLabel.Location = new System.Drawing.Point(874, 160);
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
            this.startLinkLabel.Location = new System.Drawing.Point(1098, 160);
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
            this.dateLinkLabel.Location = new System.Drawing.Point(394, 161);
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
            this.segmentLinkLabel.Location = new System.Drawing.Point(393, 143);
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
            this.metDimLabel.Location = new System.Drawing.Point(428, 185);
            this.metDimLabel.Name = "metDimLabel";
            this.metDimLabel.Size = new System.Drawing.Size(90, 12);
            this.metDimLabel.TabIndex = 46;
            this.metDimLabel.Text = "metricsDimFilter";
            // 
            // totalResultslabel
            // 
            this.totalResultslabel.AutoSize = true;
            this.totalResultslabel.Location = new System.Drawing.Point(528, 185);
            this.totalResultslabel.Name = "totalResultslabel";
            this.totalResultslabel.Size = new System.Drawing.Size(67, 12);
            this.totalResultslabel.TabIndex = 47;
            this.totalResultslabel.Text = "totalResults";
            // 
            // actualRowslabel
            // 
            this.actualRowslabel.AutoSize = true;
            this.actualRowslabel.Location = new System.Drawing.Point(609, 185);
            this.actualRowslabel.Name = "actualRowslabel";
            this.actualRowslabel.Size = new System.Drawing.Size(64, 12);
            this.actualRowslabel.TabIndex = 48;
            this.actualRowslabel.Text = "actualRows";
            // 
            // sampleLabel
            // 
            this.sampleLabel.AutoSize = true;
            this.sampleLabel.Location = new System.Drawing.Point(695, 185);
            this.sampleLabel.Name = "sampleLabel";
            this.sampleLabel.Size = new System.Drawing.Size(46, 12);
            this.sampleLabel.TabIndex = 50;
            this.sampleLabel.Text = "sample?";
            // 
            // sampleTextBox
            // 
            this.sampleTextBox.Location = new System.Drawing.Point(697, 200);
            this.sampleTextBox.Name = "sampleTextBox";
            this.sampleTextBox.Size = new System.Drawing.Size(108, 19);
            this.sampleTextBox.TabIndex = 49;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(12, 234);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(114, 12);
            this.accountLabel.TabIndex = 51;
            this.accountLabel.Text = "Account : SELECT ID";
            // 
            // propertyLabel
            // 
            this.propertyLabel.AutoSize = true;
            this.propertyLabel.Location = new System.Drawing.Point(12, 360);
            this.propertyLabel.Name = "propertyLabel";
            this.propertyLabel.Size = new System.Drawing.Size(115, 12);
            this.propertyLabel.TabIndex = 52;
            this.propertyLabel.Text = "Property : SELECT ID";
            // 
            // viewLabel
            // 
            this.viewLabel.AutoSize = true;
            this.viewLabel.Location = new System.Drawing.Point(11, 499);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(97, 12);
            this.viewLabel.TabIndex = 53;
            this.viewLabel.Text = "View : SELECT ID";
            // 
            // queryLinkLabel
            // 
            this.queryLinkLabel.AutoSize = true;
            this.queryLinkLabel.Location = new System.Drawing.Point(27, 37);
            this.queryLinkLabel.Name = "queryLinkLabel";
            this.queryLinkLabel.Size = new System.Drawing.Size(35, 12);
            this.queryLinkLabel.TabIndex = 54;
            this.queryLinkLabel.TabStop = true;
            this.queryLinkLabel.Text = "Query";
            this.queryLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.queryLinkLabel_LinkClicked);
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Items.AddRange(new object[] {
            "-"});
            this.groupComboBox.Location = new System.Drawing.Point(311, 199);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(110, 20);
            this.groupComboBox.TabIndex = 56;
            this.groupComboBox.SelectedIndexChanged += new System.EventHandler(this.groupComboBox_SelectedIndexChanged);
            // 
            // AccountTextBox
            // 
            this.AccountTextBox.Location = new System.Drawing.Point(131, 228);
            this.AccountTextBox.Name = "AccountTextBox";
            this.AccountTextBox.Size = new System.Drawing.Size(94, 19);
            this.AccountTextBox.TabIndex = 57;
            this.AccountTextBox.TextChanged += new System.EventHandler(this.AccountTextBox_TextChanged);
            // 
            // propertyTextBox
            // 
            this.propertyTextBox.Location = new System.Drawing.Point(132, 355);
            this.propertyTextBox.Name = "propertyTextBox";
            this.propertyTextBox.Size = new System.Drawing.Size(94, 19);
            this.propertyTextBox.TabIndex = 58;
            this.propertyTextBox.TextChanged += new System.EventHandler(this.propertyTextBox_TextChanged);
            // 
            // viewTextBox
            // 
            this.viewTextBox.Location = new System.Drawing.Point(131, 494);
            this.viewTextBox.Name = "viewTextBox";
            this.viewTextBox.Size = new System.Drawing.Size(94, 19);
            this.viewTextBox.TabIndex = 59;
            this.viewTextBox.TextChanged += new System.EventHandler(this.viewTextBox_TextChanged);
            // 
            // queryHistoryMenuStrip
            // 
            this.queryHistoryMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryHistoriesToolStripMenuItem});
            this.queryHistoryMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.queryHistoryMenuStrip.Name = "queryHistoryMenuStrip";
            this.queryHistoryMenuStrip.Size = new System.Drawing.Size(1225, 26);
            this.queryHistoryMenuStrip.TabIndex = 60;
            this.queryHistoryMenuStrip.Text = "menuStrip1";
            // 
            // queryHistoriesToolStripMenuItem
            // 
            this.queryHistoriesToolStripMenuItem.Name = "queryHistoriesToolStripMenuItem";
            this.queryHistoriesToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.queryHistoriesToolStripMenuItem.Text = "QueryHistories";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1225, 850);
            this.Controls.Add(this.viewTextBox);
            this.Controls.Add(this.propertyTextBox);
            this.Controls.Add(this.AccountTextBox);
            this.Controls.Add(this.groupComboBox);
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
            this.Controls.Add(this.segmentTextBox);
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
            this.Controls.Add(this.GaViewDataGridView);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.propertyDataGridView);
            this.Controls.Add(this.buttonGetAuth);
            this.Controls.Add(this.accountDataGridView);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.queryHistoryMenuStrip);
            this.Name = "Form1";
            this.Text = "Google Analytics Data Exporter";
            ((System.ComponentModel.ISupportInitialize)(this.gaDataGridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDimMetrics)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.goalDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewDetailDataGridView)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.segmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GaViewDataGridView)).EndInit();
            this.queryHistoryMenuStrip.ResumeLayout(false);
            this.queryHistoryMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.DataGridView gaDataGridViewData;
        private System.Windows.Forms.DataGridView accountDataGridView;
        private System.Windows.Forms.Button buttonGetAuth;
        private System.Windows.Forms.DataGridView propertyDataGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewDimMetrics;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView GaViewDataGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView goalDataGridView;
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
        private System.Windows.Forms.TextBox segmentTextBox;
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
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.TextBox AccountTextBox;
        private System.Windows.Forms.TextBox propertyTextBox;
        private System.Windows.Forms.TextBox viewTextBox;
        private System.Windows.Forms.DataGridView viewDetailDataGridView;
        private System.Windows.Forms.DataGridView segmentDataGridView;
        private System.Windows.Forms.MenuStrip queryHistoryMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem queryHistoriesToolStripMenuItem;
    }
}

