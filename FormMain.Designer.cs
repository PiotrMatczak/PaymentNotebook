namespace PaymentNotebook
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNewsheet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorSave = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorExit = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPl = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageOverview = new System.Windows.Forms.TabPage();
            this.overGroupBoxSummary = new System.Windows.Forms.GroupBox();
            this.overCheckBoxOnlypending = new System.Windows.Forms.CheckBox();
            this.overCheckBoxAdvanced = new System.Windows.Forms.CheckBox();
            this.overTableLayoutPanelSummary = new System.Windows.Forms.TableLayoutPanel();
            this.overTextBoxReceivables = new System.Windows.Forms.TextBox();
            this.overTextBoxPayables = new System.Windows.Forms.TextBox();
            this.overLabelPayables = new System.Windows.Forms.Label();
            this.overLabelTotal = new System.Windows.Forms.Label();
            this.overTextBoxSum = new System.Windows.Forms.TextBox();
            this.overLabelReceivables = new System.Windows.Forms.Label();
            this.overListViewTransactions = new System.Windows.Forms.ListView();
            this.overColumnHeaderId = new System.Windows.Forms.ColumnHeader();
            this.overColumnHeaderDate = new System.Windows.Forms.ColumnHeader();
            this.overColumnHeaderPerson = new System.Windows.Forms.ColumnHeader();
            this.overColumnHeaderDescription = new System.Windows.Forms.ColumnHeader();
            this.overColumnHeaderObligationtype = new System.Windows.Forms.ColumnHeader();
            this.overColumnHeaderAmount = new System.Windows.Forms.ColumnHeader();
            this.overColumnHeaderStatus = new System.Windows.Forms.ColumnHeader();
            this.overGroupBoxContractors = new System.Windows.Forms.GroupBox();
            this.overComboBoxContractorlist = new System.Windows.Forms.ComboBox();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.editTableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.editButtonSaveentry = new System.Windows.Forms.Button();
            this.editButtonDeleteentry = new System.Windows.Forms.Button();
            this.editGroupBoxModDetails = new System.Windows.Forms.GroupBox();
            this.editTableLayoutPanelRight = new System.Windows.Forms.TableLayoutPanel();
            this.editLabelObligationtype = new System.Windows.Forms.Label();
            this.editComboBoxObligationtype = new System.Windows.Forms.ComboBox();
            this.editLabelAmount = new System.Windows.Forms.Label();
            this.editTextBoxAmount = new System.Windows.Forms.TextBox();
            this.editLabelPaymentstatus = new System.Windows.Forms.Label();
            this.editComboBoxPaymentstatus = new System.Windows.Forms.ComboBox();
            this.editTableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.editTableLayoutPanelDatefield = new System.Windows.Forms.TableLayoutPanel();
            this.editCheckBoxTodaydate = new System.Windows.Forms.CheckBox();
            this.editDateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.editTextBoxName = new System.Windows.Forms.TextBox();
            this.editLabelId = new System.Windows.Forms.Label();
            this.editLabelName = new System.Windows.Forms.Label();
            this.editLabelDate = new System.Windows.Forms.Label();
            this.editLabelDescription = new System.Windows.Forms.Label();
            this.editTextBoxDescription = new System.Windows.Forms.TextBox();
            this.editTextBoxId = new System.Windows.Forms.TextBox();
            this.editGroupBoxListing = new System.Windows.Forms.GroupBox();
            this.editComboBoxListing = new System.Windows.Forms.ComboBox();
            this.saveFileDialogMain = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.menuStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageOverview.SuspendLayout();
            this.overGroupBoxSummary.SuspendLayout();
            this.overTableLayoutPanelSummary.SuspendLayout();
            this.overGroupBoxContractors.SuspendLayout();
            this.tabPageEdit.SuspendLayout();
            this.editTableLayoutPanelButtons.SuspendLayout();
            this.editGroupBoxModDetails.SuspendLayout();
            this.editTableLayoutPanelRight.SuspendLayout();
            this.editTableLayoutPanelLeft.SuspendLayout();
            this.editTableLayoutPanelDatefield.SuspendLayout();
            this.editGroupBoxListing.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemSettings,
            this.toolStripMenuItemHelp});
            resources.ApplyResources(this.menuStripMain, "menuStripMain");
            this.menuStripMain.Name = "menuStripMain";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNewsheet,
            this.toolStripMenuItemLoad,
            this.toolStripSeparatorSave,
            this.toolStripMenuItemSave,
            this.toolStripMenuItemSaveas,
            this.toolStripSeparatorExit,
            this.toolStripMenuItemExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            resources.ApplyResources(this.toolStripMenuItemFile, "toolStripMenuItemFile");
            // 
            // toolStripMenuItemNewsheet
            // 
            this.toolStripMenuItemNewsheet.Name = "toolStripMenuItemNewsheet";
            resources.ApplyResources(this.toolStripMenuItemNewsheet, "toolStripMenuItemNewsheet");
            this.toolStripMenuItemNewsheet.Click += new System.EventHandler(this.newWorksheet_Action);
            // 
            // toolStripMenuItemLoad
            // 
            this.toolStripMenuItemLoad.Name = "toolStripMenuItemLoad";
            resources.ApplyResources(this.toolStripMenuItemLoad, "toolStripMenuItemLoad");
            this.toolStripMenuItemLoad.Click += new System.EventHandler(this.openFileWithDialog_Action);
            // 
            // toolStripSeparatorSave
            // 
            this.toolStripSeparatorSave.Name = "toolStripSeparatorSave";
            resources.ApplyResources(this.toolStripSeparatorSave, "toolStripSeparatorSave");
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            resources.ApplyResources(this.toolStripMenuItemSave, "toolStripMenuItemSave");
            this.toolStripMenuItemSave.Click += new System.EventHandler(this.saveQuickToFile_Action);
            // 
            // toolStripMenuItemSaveas
            // 
            this.toolStripMenuItemSaveas.Name = "toolStripMenuItemSaveas";
            resources.ApplyResources(this.toolStripMenuItemSaveas, "toolStripMenuItemSaveas");
            this.toolStripMenuItemSaveas.Click += new System.EventHandler(this.saveToFileWithDialog_Action);
            // 
            // toolStripSeparatorExit
            // 
            this.toolStripSeparatorExit.Name = "toolStripSeparatorExit";
            resources.ApplyResources(this.toolStripSeparatorExit, "toolStripSeparatorExit");
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            resources.ApplyResources(this.toolStripMenuItemExit, "toolStripMenuItemExit");
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // toolStripMenuItemSettings
            // 
            this.toolStripMenuItemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLanguage});
            resources.ApplyResources(this.toolStripMenuItemSettings, "toolStripMenuItemSettings");
            this.toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            // 
            // toolStripMenuItemLanguage
            // 
            this.toolStripMenuItemLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPl,
            this.toolStripMenuItemEn});
            this.toolStripMenuItemLanguage.Name = "toolStripMenuItemLanguage";
            resources.ApplyResources(this.toolStripMenuItemLanguage, "toolStripMenuItemLanguage");
            // 
            // toolStripMenuItemPl
            // 
            this.toolStripMenuItemPl.Name = "toolStripMenuItemPl";
            resources.ApplyResources(this.toolStripMenuItemPl, "toolStripMenuItemPl");
            this.toolStripMenuItemPl.Tag = "pl";
            this.toolStripMenuItemPl.Click += new System.EventHandler(this.toolStripMenuItemLangselect_Click);
            // 
            // toolStripMenuItemEn
            // 
            this.toolStripMenuItemEn.Name = "toolStripMenuItemEn";
            resources.ApplyResources(this.toolStripMenuItemEn, "toolStripMenuItemEn");
            this.toolStripMenuItemEn.Tag = "en";
            this.toolStripMenuItemEn.Click += new System.EventHandler(this.toolStripMenuItemLangselect_Click);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAbout});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            resources.ApplyResources(this.toolStripMenuItemHelp, "toolStripMenuItemHelp");
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            resources.ApplyResources(this.toolStripMenuItemAbout, "toolStripMenuItemAbout");
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.AboutBoxShow_Action);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageOverview);
            this.tabControlMain.Controls.Add(this.tabPageEdit);
            resources.ApplyResources(this.tabControlMain, "tabControlMain");
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.refreshCurrentTab_Action);
            // 
            // tabPageOverview
            // 
            this.tabPageOverview.Controls.Add(this.overGroupBoxSummary);
            this.tabPageOverview.Controls.Add(this.overListViewTransactions);
            this.tabPageOverview.Controls.Add(this.overGroupBoxContractors);
            resources.ApplyResources(this.tabPageOverview, "tabPageOverview");
            this.tabPageOverview.Name = "tabPageOverview";
            this.tabPageOverview.UseVisualStyleBackColor = true;
            // 
            // overGroupBoxSummary
            // 
            resources.ApplyResources(this.overGroupBoxSummary, "overGroupBoxSummary");
            this.overGroupBoxSummary.Controls.Add(this.overCheckBoxOnlypending);
            this.overGroupBoxSummary.Controls.Add(this.overCheckBoxAdvanced);
            this.overGroupBoxSummary.Controls.Add(this.overTableLayoutPanelSummary);
            this.overGroupBoxSummary.Name = "overGroupBoxSummary";
            this.overGroupBoxSummary.TabStop = false;
            // 
            // overCheckBoxOnlypending
            // 
            resources.ApplyResources(this.overCheckBoxOnlypending, "overCheckBoxOnlypending");
            this.overCheckBoxOnlypending.Name = "overCheckBoxOnlypending";
            this.overCheckBoxOnlypending.UseVisualStyleBackColor = true;
            this.overCheckBoxOnlypending.CheckedChanged += new System.EventHandler(this.overComboBoxContractorlist_Refresh);
            // 
            // overCheckBoxAdvanced
            // 
            resources.ApplyResources(this.overCheckBoxAdvanced, "overCheckBoxAdvanced");
            this.overCheckBoxAdvanced.Name = "overCheckBoxAdvanced";
            this.overCheckBoxAdvanced.UseVisualStyleBackColor = true;
            // 
            // overTableLayoutPanelSummary
            // 
            resources.ApplyResources(this.overTableLayoutPanelSummary, "overTableLayoutPanelSummary");
            this.overTableLayoutPanelSummary.Controls.Add(this.overTextBoxReceivables, 0, 3);
            this.overTableLayoutPanelSummary.Controls.Add(this.overTextBoxPayables, 0, 1);
            this.overTableLayoutPanelSummary.Controls.Add(this.overLabelPayables, 0, 0);
            this.overTableLayoutPanelSummary.Controls.Add(this.overLabelTotal, 0, 4);
            this.overTableLayoutPanelSummary.Controls.Add(this.overTextBoxSum, 0, 5);
            this.overTableLayoutPanelSummary.Controls.Add(this.overLabelReceivables, 0, 2);
            this.overTableLayoutPanelSummary.Name = "overTableLayoutPanelSummary";
            // 
            // overTextBoxReceivables
            // 
            resources.ApplyResources(this.overTextBoxReceivables, "overTextBoxReceivables");
            this.overTextBoxReceivables.Name = "overTextBoxReceivables";
            this.overTextBoxReceivables.ReadOnly = true;
            // 
            // overTextBoxPayables
            // 
            resources.ApplyResources(this.overTextBoxPayables, "overTextBoxPayables");
            this.overTextBoxPayables.Name = "overTextBoxPayables";
            this.overTextBoxPayables.ReadOnly = true;
            // 
            // overLabelPayables
            // 
            resources.ApplyResources(this.overLabelPayables, "overLabelPayables");
            this.overLabelPayables.Name = "overLabelPayables";
            // 
            // overLabelTotal
            // 
            resources.ApplyResources(this.overLabelTotal, "overLabelTotal");
            this.overLabelTotal.Name = "overLabelTotal";
            // 
            // overTextBoxSum
            // 
            resources.ApplyResources(this.overTextBoxSum, "overTextBoxSum");
            this.overTextBoxSum.Name = "overTextBoxSum";
            this.overTextBoxSum.ReadOnly = true;
            // 
            // overLabelReceivables
            // 
            resources.ApplyResources(this.overLabelReceivables, "overLabelReceivables");
            this.overLabelReceivables.Name = "overLabelReceivables";
            // 
            // overListViewTransactions
            // 
            this.overListViewTransactions.Activation = System.Windows.Forms.ItemActivation.OneClick;
            resources.ApplyResources(this.overListViewTransactions, "overListViewTransactions");
            this.overListViewTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.overColumnHeaderId,
            this.overColumnHeaderDate,
            this.overColumnHeaderPerson,
            this.overColumnHeaderDescription,
            this.overColumnHeaderObligationtype,
            this.overColumnHeaderAmount,
            this.overColumnHeaderStatus});
            this.overListViewTransactions.HoverSelection = true;
            this.overListViewTransactions.Name = "overListViewTransactions";
            this.overListViewTransactions.UseCompatibleStateImageBehavior = false;
            this.overListViewTransactions.View = System.Windows.Forms.View.Details;
            this.overListViewTransactions.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.overListViewTransactions_ColumnClick);
            // 
            // overColumnHeaderId
            // 
            resources.ApplyResources(this.overColumnHeaderId, "overColumnHeaderId");
            // 
            // overColumnHeaderDate
            // 
            resources.ApplyResources(this.overColumnHeaderDate, "overColumnHeaderDate");
            // 
            // overColumnHeaderPerson
            // 
            resources.ApplyResources(this.overColumnHeaderPerson, "overColumnHeaderPerson");
            // 
            // overColumnHeaderDescription
            // 
            resources.ApplyResources(this.overColumnHeaderDescription, "overColumnHeaderDescription");
            // 
            // overColumnHeaderObligationtype
            // 
            resources.ApplyResources(this.overColumnHeaderObligationtype, "overColumnHeaderObligationtype");
            // 
            // overColumnHeaderAmount
            // 
            resources.ApplyResources(this.overColumnHeaderAmount, "overColumnHeaderAmount");
            // 
            // overColumnHeaderStatus
            // 
            resources.ApplyResources(this.overColumnHeaderStatus, "overColumnHeaderStatus");
            // 
            // overGroupBoxContractors
            // 
            resources.ApplyResources(this.overGroupBoxContractors, "overGroupBoxContractors");
            this.overGroupBoxContractors.Controls.Add(this.overComboBoxContractorlist);
            this.overGroupBoxContractors.Name = "overGroupBoxContractors";
            this.overGroupBoxContractors.TabStop = false;
            // 
            // overComboBoxContractorlist
            // 
            resources.ApplyResources(this.overComboBoxContractorlist, "overComboBoxContractorlist");
            this.overComboBoxContractorlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.overComboBoxContractorlist.FormattingEnabled = true;
            this.overComboBoxContractorlist.Name = "overComboBoxContractorlist";
            this.overComboBoxContractorlist.SelectedIndexChanged += new System.EventHandler(this.overComboBoxContractorlist_Refresh);
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Controls.Add(this.editTableLayoutPanelButtons);
            this.tabPageEdit.Controls.Add(this.editGroupBoxModDetails);
            this.tabPageEdit.Controls.Add(this.editGroupBoxListing);
            resources.ApplyResources(this.tabPageEdit, "tabPageEdit");
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // editTableLayoutPanelButtons
            // 
            resources.ApplyResources(this.editTableLayoutPanelButtons, "editTableLayoutPanelButtons");
            this.editTableLayoutPanelButtons.Controls.Add(this.editButtonSaveentry, 0, 0);
            this.editTableLayoutPanelButtons.Controls.Add(this.editButtonDeleteentry, 1, 0);
            this.editTableLayoutPanelButtons.Name = "editTableLayoutPanelButtons";
            // 
            // editButtonSaveentry
            // 
            resources.ApplyResources(this.editButtonSaveentry, "editButtonSaveentry");
            this.editButtonSaveentry.Name = "editButtonSaveentry";
            this.editButtonSaveentry.UseVisualStyleBackColor = true;
            this.editButtonSaveentry.Click += new System.EventHandler(this.validateAndAddEntry_Action);
            // 
            // editButtonDeleteentry
            // 
            resources.ApplyResources(this.editButtonDeleteentry, "editButtonDeleteentry");
            this.editButtonDeleteentry.Name = "editButtonDeleteentry";
            this.editButtonDeleteentry.UseVisualStyleBackColor = true;
            this.editButtonDeleteentry.Click += new System.EventHandler(this.editButtonDeleteentry_Click);
            // 
            // editGroupBoxModDetails
            // 
            resources.ApplyResources(this.editGroupBoxModDetails, "editGroupBoxModDetails");
            this.editGroupBoxModDetails.Controls.Add(this.editTableLayoutPanelRight);
            this.editGroupBoxModDetails.Controls.Add(this.editTableLayoutPanelLeft);
            this.editGroupBoxModDetails.Name = "editGroupBoxModDetails";
            this.editGroupBoxModDetails.TabStop = false;
            // 
            // editTableLayoutPanelRight
            // 
            resources.ApplyResources(this.editTableLayoutPanelRight, "editTableLayoutPanelRight");
            this.editTableLayoutPanelRight.Controls.Add(this.editLabelObligationtype, 0, 0);
            this.editTableLayoutPanelRight.Controls.Add(this.editComboBoxObligationtype, 1, 0);
            this.editTableLayoutPanelRight.Controls.Add(this.editLabelAmount, 0, 1);
            this.editTableLayoutPanelRight.Controls.Add(this.editTextBoxAmount, 1, 1);
            this.editTableLayoutPanelRight.Controls.Add(this.editLabelPaymentstatus, 0, 2);
            this.editTableLayoutPanelRight.Controls.Add(this.editComboBoxPaymentstatus, 1, 2);
            this.editTableLayoutPanelRight.Name = "editTableLayoutPanelRight";
            // 
            // editLabelObligationtype
            // 
            resources.ApplyResources(this.editLabelObligationtype, "editLabelObligationtype");
            this.editLabelObligationtype.Name = "editLabelObligationtype";
            // 
            // editComboBoxObligationtype
            // 
            resources.ApplyResources(this.editComboBoxObligationtype, "editComboBoxObligationtype");
            this.editComboBoxObligationtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editComboBoxObligationtype.FormattingEnabled = true;
            this.editComboBoxObligationtype.Name = "editComboBoxObligationtype";
            // 
            // editLabelAmount
            // 
            resources.ApplyResources(this.editLabelAmount, "editLabelAmount");
            this.editLabelAmount.Name = "editLabelAmount";
            // 
            // editTextBoxAmount
            // 
            resources.ApplyResources(this.editTextBoxAmount, "editTextBoxAmount");
            this.editTextBoxAmount.Name = "editTextBoxAmount";
            // 
            // editLabelPaymentstatus
            // 
            resources.ApplyResources(this.editLabelPaymentstatus, "editLabelPaymentstatus");
            this.editLabelPaymentstatus.Name = "editLabelPaymentstatus";
            // 
            // editComboBoxPaymentstatus
            // 
            resources.ApplyResources(this.editComboBoxPaymentstatus, "editComboBoxPaymentstatus");
            this.editComboBoxPaymentstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editComboBoxPaymentstatus.FormattingEnabled = true;
            this.editComboBoxPaymentstatus.Name = "editComboBoxPaymentstatus";
            // 
            // editTableLayoutPanelLeft
            // 
            resources.ApplyResources(this.editTableLayoutPanelLeft, "editTableLayoutPanelLeft");
            this.editTableLayoutPanelLeft.Controls.Add(this.editTableLayoutPanelDatefield, 1, 3);
            this.editTableLayoutPanelLeft.Controls.Add(this.editTextBoxName, 1, 1);
            this.editTableLayoutPanelLeft.Controls.Add(this.editLabelId, 0, 0);
            this.editTableLayoutPanelLeft.Controls.Add(this.editLabelName, 0, 1);
            this.editTableLayoutPanelLeft.Controls.Add(this.editLabelDate, 0, 3);
            this.editTableLayoutPanelLeft.Controls.Add(this.editLabelDescription, 0, 2);
            this.editTableLayoutPanelLeft.Controls.Add(this.editTextBoxDescription, 1, 2);
            this.editTableLayoutPanelLeft.Controls.Add(this.editTextBoxId, 1, 0);
            this.editTableLayoutPanelLeft.Name = "editTableLayoutPanelLeft";
            // 
            // editTableLayoutPanelDatefield
            // 
            resources.ApplyResources(this.editTableLayoutPanelDatefield, "editTableLayoutPanelDatefield");
            this.editTableLayoutPanelDatefield.Controls.Add(this.editCheckBoxTodaydate, 0, 1);
            this.editTableLayoutPanelDatefield.Controls.Add(this.editDateTimePickerDate, 0, 0);
            this.editTableLayoutPanelDatefield.Name = "editTableLayoutPanelDatefield";
            // 
            // editCheckBoxTodaydate
            // 
            resources.ApplyResources(this.editCheckBoxTodaydate, "editCheckBoxTodaydate");
            this.editCheckBoxTodaydate.Name = "editCheckBoxTodaydate";
            this.editCheckBoxTodaydate.UseVisualStyleBackColor = true;
            this.editCheckBoxTodaydate.CheckedChanged += new System.EventHandler(this.editCheckBoxTodaydate_CheckedChanged);
            // 
            // editDateTimePickerDate
            // 
            resources.ApplyResources(this.editDateTimePickerDate, "editDateTimePickerDate");
            this.editDateTimePickerDate.Checked = false;
            this.editDateTimePickerDate.Name = "editDateTimePickerDate";
            // 
            // editTextBoxName
            // 
            resources.ApplyResources(this.editTextBoxName, "editTextBoxName");
            this.editTextBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.editTextBoxName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.editTextBoxName.Name = "editTextBoxName";
            // 
            // editLabelId
            // 
            resources.ApplyResources(this.editLabelId, "editLabelId");
            this.editLabelId.Name = "editLabelId";
            // 
            // editLabelName
            // 
            resources.ApplyResources(this.editLabelName, "editLabelName");
            this.editLabelName.Name = "editLabelName";
            // 
            // editLabelDate
            // 
            resources.ApplyResources(this.editLabelDate, "editLabelDate");
            this.editLabelDate.Name = "editLabelDate";
            // 
            // editLabelDescription
            // 
            resources.ApplyResources(this.editLabelDescription, "editLabelDescription");
            this.editLabelDescription.Name = "editLabelDescription";
            // 
            // editTextBoxDescription
            // 
            resources.ApplyResources(this.editTextBoxDescription, "editTextBoxDescription");
            this.editTextBoxDescription.Name = "editTextBoxDescription";
            // 
            // editTextBoxId
            // 
            resources.ApplyResources(this.editTextBoxId, "editTextBoxId");
            this.editTextBoxId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.editTextBoxId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.editTextBoxId.Name = "editTextBoxId";
            this.editTextBoxId.ReadOnly = true;
            // 
            // editGroupBoxListing
            // 
            resources.ApplyResources(this.editGroupBoxListing, "editGroupBoxListing");
            this.editGroupBoxListing.Controls.Add(this.editComboBoxListing);
            this.editGroupBoxListing.Name = "editGroupBoxListing";
            this.editGroupBoxListing.TabStop = false;
            // 
            // editComboBoxListing
            // 
            resources.ApplyResources(this.editComboBoxListing, "editComboBoxListing");
            this.editComboBoxListing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editComboBoxListing.FormattingEnabled = true;
            this.editComboBoxListing.Name = "editComboBoxListing";
            this.editComboBoxListing.SelectedIndexChanged += new System.EventHandler(this.editComboBoxListing_SelectedIndexChanged);
            // 
            // saveFileDialogMain
            // 
            this.saveFileDialogMain.FileName = "Nowy arkusz";
            resources.ApplyResources(this.saveFileDialogMain, "saveFileDialogMain");
            this.saveFileDialogMain.InitialDirectory = "C:\\";
            // 
            // openFileDialogMain
            // 
            resources.ApplyResources(this.openFileDialogMain, "openFileDialogMain");
            this.openFileDialogMain.InitialDirectory = "C:\\";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Activated += new System.EventHandler(this.overComboBoxContractorlist_Refresh);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageOverview.ResumeLayout(false);
            this.overGroupBoxSummary.ResumeLayout(false);
            this.overGroupBoxSummary.PerformLayout();
            this.overTableLayoutPanelSummary.ResumeLayout(false);
            this.overTableLayoutPanelSummary.PerformLayout();
            this.overGroupBoxContractors.ResumeLayout(false);
            this.tabPageEdit.ResumeLayout(false);
            this.editTableLayoutPanelButtons.ResumeLayout(false);
            this.editGroupBoxModDetails.ResumeLayout(false);
            this.editTableLayoutPanelRight.ResumeLayout(false);
            this.editTableLayoutPanelRight.PerformLayout();
            this.editTableLayoutPanelLeft.ResumeLayout(false);
            this.editTableLayoutPanelLeft.PerformLayout();
            this.editTableLayoutPanelDatefield.ResumeLayout(false);
            this.editTableLayoutPanelDatefield.PerformLayout();
            this.editGroupBoxListing.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStripMain;
        private ToolStripMenuItem toolStripMenuItemFile;
        private ToolStripMenuItem toolStripMenuItemLoad;
        private ToolStripMenuItem toolStripMenuItemNewsheet;
        private ToolStripSeparator toolStripSeparatorExit;
        private ToolStripMenuItem toolStripMenuItemExit;
        private TabControl tabControlMain;
        private TabPage tabPageEdit;
        private TabPage tabPageOverview;
        private ComboBox overComboBoxContractorlist;
        private ListView overListViewTransactions;
        private ColumnHeader overColumnHeaderDate;
        private ColumnHeader overColumnHeaderPerson;
        private GroupBox overGroupBoxSummary;
        private ColumnHeader overColumnHeaderObligationtype;
        private ColumnHeader overColumnHeaderStatus;
        private TableLayoutPanel overTableLayoutPanelSummary;
        private TextBox overTextBoxReceivables;
        private TextBox overTextBoxPayables;
        private Label overLabelPayables;
        private Label overLabelReceivables;
        private Label overLabelTotal;
        private TextBox overTextBoxSum;
        private ColumnHeader overColumnHeaderDescription;
        private ColumnHeader overColumnHeaderAmount;
        private ToolStripMenuItem toolStripMenuItemHelp;
        private ToolStripMenuItem toolStripMenuItemAbout;
        private GroupBox overGroupBoxContractors;
        private CheckBox overCheckBoxAdvanced;
        private GroupBox editGroupBoxModDetails;
        private GroupBox editGroupBoxListing;
        private ComboBox editComboBoxListing;
        private Button editButtonSaveentry;
        private TableLayoutPanel editTableLayoutPanelLeft;
        private TextBox editTextBoxName;
        private Label editLabelName;
        private Label editLabelDate;
        private TextBox editTextBoxDescription;
        private Label editLabelDescription;
        private TableLayoutPanel editTableLayoutPanelRight;
        private Label editLabelObligationtype;
        private ComboBox editComboBoxObligationtype;
        private Label editLabelAmount;
        private TextBox editTextBoxAmount;
        private CheckBox editCheckBoxTodaydate;
        private ToolStripSeparator toolStripSeparatorSave;
        private ToolStripMenuItem toolStripMenuItemSave;
        private ToolStripMenuItem toolStripMenuItemSaveas;
        private ToolStripMenuItem toolStripMenuItemSettings;
        private ToolStripMenuItem toolStripMenuItemLanguage;
        private ToolStripMenuItem toolStripMenuItemEn;
        private ToolStripMenuItem toolStripMenuItemPl;
        private DateTimePicker editDateTimePickerDate;
        private TableLayoutPanel editTableLayoutPanelDatefield;
        private Label editLabelId;
        private TextBox editTextBoxId;
        private TableLayoutPanel editTableLayoutPanelButtons;
        private Button editButtonDeleteentry;
        private ColumnHeader overColumnHeaderId;
        private Label editLabelPaymentstatus;
        private ComboBox editComboBoxPaymentstatus;
        private CheckBox overCheckBoxOnlypending;
        private SaveFileDialog saveFileDialogMain;
        private OpenFileDialog openFileDialogMain;
    }
}