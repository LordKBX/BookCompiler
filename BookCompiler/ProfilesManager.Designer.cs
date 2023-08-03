namespace BookCompiler
{
    partial class ProfilesManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilesManager));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            ProfilesList = new DataGridView();
            ColumnPresetName = new DataGridViewTextBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            IndexGroupBox = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            IndexParentLabel = new Label();
            IndexParentTextBox = new TextBox();
            IndexObjectLabel = new Label();
            IndexObjectTextBox = new TextBox();
            IndexParsingObjectLabel = new Label();
            IndexParsingObjectTextBox = new TextBox();
            IndexTemplateLinkObjectLabel = new Label();
            IndexTemplateLinkObjectTextBox = new TextBox();
            IndexTemplateNameObjectLabel = new Label();
            IndexTemplateNameObjectTextBox = new TextBox();
            IndexParsingOrderLabel = new Label();
            IndexParsingOrderComboBox = new ComboBox();
            IndexTitleLabel = new Label();
            IndexTitleTextBox = new TextBox();
            IndexImageLabel = new Label();
            IndexImageTextBox = new TextBox();
            PageGroupBox = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            PageParentLabel = new Label();
            PageParentTextBox = new TextBox();
            PageExcludedLabel = new Label();
            PageExcludedTextBox = new TextBox();
            PageCloudFlareProtectedLabel = new Label();
            PageCloudFlareProtectedComboBox = new ComboBox();
            SaveButton = new Button();
            DeleteButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            IndexPresetAddButton = new Button();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilesList).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            IndexGroupBox.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            PageGroupBox.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(ProfilesList, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(714, 761);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(244, 25);
            label1.TabIndex = 0;
            label1.Text = "Profiles List";
            // 
            // ProfilesList
            // 
            ProfilesList.AllowUserToAddRows = false;
            ProfilesList.AllowUserToDeleteRows = false;
            ProfilesList.AllowUserToResizeColumns = false;
            ProfilesList.AllowUserToResizeRows = false;
            ProfilesList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            ProfilesList.BackgroundColor = Color.White;
            ProfilesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProfilesList.Columns.AddRange(new DataGridViewColumn[] { ColumnPresetName });
            ProfilesList.Dock = DockStyle.Fill;
            ProfilesList.Location = new Point(3, 43);
            ProfilesList.MultiSelect = false;
            ProfilesList.Name = "ProfilesList";
            ProfilesList.ReadOnly = true;
            ProfilesList.RowHeadersVisible = false;
            ProfilesList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            ProfilesList.RowTemplate.Height = 25;
            ProfilesList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProfilesList.ShowCellErrors = false;
            ProfilesList.ShowEditingIcon = false;
            ProfilesList.ShowRowErrors = false;
            ProfilesList.Size = new Size(244, 715);
            ProfilesList.TabIndex = 1;
            ProfilesList.SelectionChanged += ProfilesList_SelectionChanged;
            // 
            // ColumnPresetName
            // 
            ColumnPresetName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnPresetName.DataPropertyName = "Name";
            ColumnPresetName.HeaderText = "Name";
            ColumnPresetName.MinimumWidth = 100;
            ColumnPresetName.Name = "ColumnPresetName";
            ColumnPresetName.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(tableLayoutPanel6);
            flowLayoutPanel1.Controls.Add(IndexGroupBox);
            flowLayoutPanel1.Controls.Add(PageGroupBox);
            flowLayoutPanel1.Controls.Add(SaveButton);
            flowLayoutPanel1.Controls.Add(DeleteButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(253, 43);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(458, 715);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 183F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(NameLabel, 0, 0);
            tableLayoutPanel6.Controls.Add(NameTextBox, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Top;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(450, 40);
            tableLayoutPanel6.TabIndex = 6;
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NameLabel.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(5, 1);
            NameLabel.Margin = new Padding(5, 0, 5, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(173, 38);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name";
            NameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.Location = new Point(183, 7);
            NameTextBox.Margin = new Padding(0, 0, 12, 0);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "ul";
            NameTextBox.ReadOnly = true;
            NameTextBox.Size = new Size(255, 26);
            NameTextBox.TabIndex = 1;
            // 
            // IndexGroupBox
            // 
            IndexGroupBox.AutoSize = true;
            IndexGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            IndexGroupBox.BackColor = Color.Transparent;
            IndexGroupBox.Controls.Add(tableLayoutPanel4);
            IndexGroupBox.Dock = DockStyle.Top;
            IndexGroupBox.ForeColor = Color.Black;
            IndexGroupBox.Location = new Point(3, 49);
            IndexGroupBox.MinimumSize = new Size(450, 370);
            IndexGroupBox.Name = "IndexGroupBox";
            IndexGroupBox.Size = new Size(450, 370);
            IndexGroupBox.TabIndex = 1;
            IndexGroupBox.TabStop = false;
            IndexGroupBox.Text = "Index Parser";
            IndexGroupBox.Paint += PaintroupBox;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(IndexParentLabel, 0, 1);
            tableLayoutPanel4.Controls.Add(IndexParentTextBox, 1, 1);
            tableLayoutPanel4.Controls.Add(IndexObjectLabel, 0, 2);
            tableLayoutPanel4.Controls.Add(IndexObjectTextBox, 1, 2);
            tableLayoutPanel4.Controls.Add(IndexParsingObjectLabel, 0, 3);
            tableLayoutPanel4.Controls.Add(IndexParsingObjectTextBox, 1, 3);
            tableLayoutPanel4.Controls.Add(IndexTemplateLinkObjectLabel, 0, 4);
            tableLayoutPanel4.Controls.Add(IndexTemplateLinkObjectTextBox, 1, 4);
            tableLayoutPanel4.Controls.Add(IndexTemplateNameObjectLabel, 0, 5);
            tableLayoutPanel4.Controls.Add(IndexTemplateNameObjectTextBox, 1, 5);
            tableLayoutPanel4.Controls.Add(IndexParsingOrderLabel, 0, 6);
            tableLayoutPanel4.Controls.Add(IndexParsingOrderComboBox, 1, 6);
            tableLayoutPanel4.Controls.Add(IndexTitleLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(IndexTitleTextBox, 1, 0);
            tableLayoutPanel4.Controls.Add(IndexImageLabel, 0, 7);
            tableLayoutPanel4.Controls.Add(IndexImageTextBox, 1, 7);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 33);
            tableLayoutPanel4.Margin = new Padding(5);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(0, 0, 10, 0);
            tableLayoutPanel4.RowCount = 9;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(444, 334);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // IndexParentLabel
            // 
            IndexParentLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IndexParentLabel.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IndexParentLabel.Location = new Point(5, 41);
            IndexParentLabel.Margin = new Padding(5, 0, 5, 0);
            IndexParentLabel.Name = "IndexParentLabel";
            IndexParentLabel.Size = new Size(170, 38);
            IndexParentLabel.TabIndex = 0;
            IndexParentLabel.Text = "Parent block";
            IndexParentLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IndexParentTextBox
            // 
            IndexParentTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IndexParentTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IndexParentTextBox.Location = new Point(180, 47);
            IndexParentTextBox.Margin = new Padding(0);
            IndexParentTextBox.Name = "IndexParentTextBox";
            IndexParentTextBox.PlaceholderText = "ul";
            IndexParentTextBox.Size = new Size(254, 26);
            IndexParentTextBox.TabIndex = 1;
            // 
            // IndexObjectLabel
            // 
            IndexObjectLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IndexObjectLabel.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IndexObjectLabel.Location = new Point(5, 81);
            IndexObjectLabel.Margin = new Padding(5, 0, 5, 0);
            IndexObjectLabel.Name = "IndexObjectLabel";
            IndexObjectLabel.Size = new Size(170, 38);
            IndexObjectLabel.TabIndex = 0;
            IndexObjectLabel.Text = "Line Object";
            IndexObjectLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IndexObjectTextBox
            // 
            IndexObjectTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IndexObjectTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IndexObjectTextBox.Location = new Point(180, 87);
            IndexObjectTextBox.Margin = new Padding(0);
            IndexObjectTextBox.Name = "IndexObjectTextBox";
            IndexObjectTextBox.PlaceholderText = "li";
            IndexObjectTextBox.Size = new Size(254, 26);
            IndexObjectTextBox.TabIndex = 1;
            // 
            // IndexParsingObjectLabel
            // 
            IndexParsingObjectLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IndexParsingObjectLabel.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IndexParsingObjectLabel.Location = new Point(5, 121);
            IndexParsingObjectLabel.Margin = new Padding(5, 0, 5, 0);
            IndexParsingObjectLabel.Name = "IndexParsingObjectLabel";
            IndexParsingObjectLabel.Size = new Size(170, 38);
            IndexParsingObjectLabel.TabIndex = 0;
            IndexParsingObjectLabel.Text = "RegExp Parsing Object";
            IndexParsingObjectLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IndexParsingObjectTextBox
            // 
            IndexParsingObjectTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IndexParsingObjectTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IndexParsingObjectTextBox.Location = new Point(180, 127);
            IndexParsingObjectTextBox.Margin = new Padding(0);
            IndexParsingObjectTextBox.Name = "IndexParsingObjectTextBox";
            IndexParsingObjectTextBox.PlaceholderText = "<a href=\"(.*)\">(.*)</a>";
            IndexParsingObjectTextBox.Size = new Size(254, 26);
            IndexParsingObjectTextBox.TabIndex = 1;
            // 
            // IndexTemplateLinkObjectLabel
            // 
            IndexTemplateLinkObjectLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IndexTemplateLinkObjectLabel.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IndexTemplateLinkObjectLabel.Location = new Point(5, 161);
            IndexTemplateLinkObjectLabel.Margin = new Padding(5, 0, 5, 0);
            IndexTemplateLinkObjectLabel.Name = "IndexTemplateLinkObjectLabel";
            IndexTemplateLinkObjectLabel.Size = new Size(170, 38);
            IndexTemplateLinkObjectLabel.TabIndex = 0;
            IndexTemplateLinkObjectLabel.Text = "Template Link Object";
            IndexTemplateLinkObjectLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IndexTemplateLinkObjectTextBox
            // 
            IndexTemplateLinkObjectTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IndexTemplateLinkObjectTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IndexTemplateLinkObjectTextBox.Location = new Point(180, 167);
            IndexTemplateLinkObjectTextBox.Margin = new Padding(0);
            IndexTemplateLinkObjectTextBox.Name = "IndexTemplateLinkObjectTextBox";
            IndexTemplateLinkObjectTextBox.PlaceholderText = "$1";
            IndexTemplateLinkObjectTextBox.Size = new Size(254, 26);
            IndexTemplateLinkObjectTextBox.TabIndex = 1;
            // 
            // IndexTemplateNameObjectLabel
            // 
            IndexTemplateNameObjectLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IndexTemplateNameObjectLabel.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IndexTemplateNameObjectLabel.Location = new Point(5, 201);
            IndexTemplateNameObjectLabel.Margin = new Padding(5, 0, 5, 0);
            IndexTemplateNameObjectLabel.Name = "IndexTemplateNameObjectLabel";
            IndexTemplateNameObjectLabel.Size = new Size(170, 38);
            IndexTemplateNameObjectLabel.TabIndex = 0;
            IndexTemplateNameObjectLabel.Text = "Template Name Object";
            IndexTemplateNameObjectLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IndexTemplateNameObjectTextBox
            // 
            IndexTemplateNameObjectTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IndexTemplateNameObjectTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IndexTemplateNameObjectTextBox.Location = new Point(180, 207);
            IndexTemplateNameObjectTextBox.Margin = new Padding(0);
            IndexTemplateNameObjectTextBox.Name = "IndexTemplateNameObjectTextBox";
            IndexTemplateNameObjectTextBox.PlaceholderText = "$2";
            IndexTemplateNameObjectTextBox.Size = new Size(254, 26);
            IndexTemplateNameObjectTextBox.TabIndex = 1;
            // 
            // IndexParsingOrderLabel
            // 
            IndexParsingOrderLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IndexParsingOrderLabel.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IndexParsingOrderLabel.Location = new Point(5, 241);
            IndexParsingOrderLabel.Margin = new Padding(5, 0, 5, 0);
            IndexParsingOrderLabel.Name = "IndexParsingOrderLabel";
            IndexParsingOrderLabel.Size = new Size(170, 38);
            IndexParsingOrderLabel.TabIndex = 0;
            IndexParsingOrderLabel.Text = "Parsing Order Object";
            IndexParsingOrderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IndexParsingOrderComboBox
            // 
            IndexParsingOrderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            IndexParsingOrderComboBox.FlatStyle = FlatStyle.Popup;
            IndexParsingOrderComboBox.FormattingEnabled = true;
            IndexParsingOrderComboBox.Items.AddRange(new object[] { "Ascendent", "Descendent" });
            IndexParsingOrderComboBox.Location = new Point(180, 244);
            IndexParsingOrderComboBox.Margin = new Padding(0, 4, 0, 0);
            IndexParsingOrderComboBox.Name = "IndexParsingOrderComboBox";
            IndexParsingOrderComboBox.Size = new Size(253, 33);
            IndexParsingOrderComboBox.TabIndex = 1;
            // 
            // IndexTitleLabel
            // 
            IndexTitleLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IndexTitleLabel.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IndexTitleLabel.Location = new Point(5, 1);
            IndexTitleLabel.Margin = new Padding(5, 0, 5, 0);
            IndexTitleLabel.Name = "IndexTitleLabel";
            IndexTitleLabel.Size = new Size(170, 38);
            IndexTitleLabel.TabIndex = 0;
            IndexTitleLabel.Text = "Title block";
            IndexTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IndexTitleTextBox
            // 
            IndexTitleTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IndexTitleTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IndexTitleTextBox.Location = new Point(180, 7);
            IndexTitleTextBox.Margin = new Padding(0);
            IndexTitleTextBox.Name = "IndexTitleTextBox";
            IndexTitleTextBox.PlaceholderText = "ul";
            IndexTitleTextBox.Size = new Size(254, 26);
            IndexTitleTextBox.TabIndex = 1;
            // 
            // IndexImageLabel
            // 
            IndexImageLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IndexImageLabel.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IndexImageLabel.Location = new Point(5, 281);
            IndexImageLabel.Margin = new Padding(5, 0, 5, 0);
            IndexImageLabel.Name = "IndexImageLabel";
            IndexImageLabel.Size = new Size(170, 38);
            IndexImageLabel.TabIndex = 0;
            IndexImageLabel.Text = "Image Object";
            IndexImageLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IndexImageTextBox
            // 
            IndexImageTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IndexImageTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IndexImageTextBox.Location = new Point(180, 287);
            IndexImageTextBox.Margin = new Padding(0);
            IndexImageTextBox.Name = "IndexImageTextBox";
            IndexImageTextBox.PlaceholderText = "$2";
            IndexImageTextBox.Size = new Size(254, 26);
            IndexImageTextBox.TabIndex = 1;
            // 
            // PageGroupBox
            // 
            PageGroupBox.Controls.Add(tableLayoutPanel5);
            PageGroupBox.Dock = DockStyle.Top;
            PageGroupBox.Location = new Point(3, 425);
            PageGroupBox.Margin = new Padding(3, 3, 3, 10);
            PageGroupBox.MinimumSize = new Size(0, 170);
            PageGroupBox.Name = "PageGroupBox";
            PageGroupBox.Size = new Size(450, 170);
            PageGroupBox.TabIndex = 5;
            PageGroupBox.TabStop = false;
            PageGroupBox.Text = "Page Parsing";
            PageGroupBox.Paint += PaintroupBox;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.Transparent;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(PageParentLabel, 0, 0);
            tableLayoutPanel5.Controls.Add(PageParentTextBox, 1, 0);
            tableLayoutPanel5.Controls.Add(PageExcludedLabel, 0, 1);
            tableLayoutPanel5.Controls.Add(PageExcludedTextBox, 1, 1);
            tableLayoutPanel5.Controls.Add(PageCloudFlareProtectedLabel, 0, 2);
            tableLayoutPanel5.Controls.Add(PageCloudFlareProtectedComboBox, 1, 2);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 33);
            tableLayoutPanel5.Margin = new Padding(5);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.Padding = new Padding(0, 0, 10, 0);
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(444, 134);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // PageParentLabel
            // 
            PageParentLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PageParentLabel.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PageParentLabel.Location = new Point(5, 1);
            PageParentLabel.Margin = new Padding(5, 0, 5, 0);
            PageParentLabel.Name = "PageParentLabel";
            PageParentLabel.Size = new Size(170, 38);
            PageParentLabel.TabIndex = 0;
            PageParentLabel.Text = "Parent block";
            PageParentLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PageParentTextBox
            // 
            PageParentTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PageParentTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PageParentTextBox.Location = new Point(180, 7);
            PageParentTextBox.Margin = new Padding(0);
            PageParentTextBox.Name = "PageParentTextBox";
            PageParentTextBox.PlaceholderText = "div.aa";
            PageParentTextBox.Size = new Size(254, 26);
            PageParentTextBox.TabIndex = 1;
            // 
            // PageExcludedLabel
            // 
            PageExcludedLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PageExcludedLabel.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PageExcludedLabel.Location = new Point(5, 41);
            PageExcludedLabel.Margin = new Padding(5, 0, 5, 0);
            PageExcludedLabel.Name = "PageExcludedLabel";
            PageExcludedLabel.Size = new Size(170, 38);
            PageExcludedLabel.TabIndex = 0;
            PageExcludedLabel.Text = "Excluded(split by , )";
            PageExcludedLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PageExcludedTextBox
            // 
            PageExcludedTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PageExcludedTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PageExcludedTextBox.Location = new Point(180, 47);
            PageExcludedTextBox.Margin = new Padding(0);
            PageExcludedTextBox.Name = "PageExcludedTextBox";
            PageExcludedTextBox.PlaceholderText = "div.aa";
            PageExcludedTextBox.Size = new Size(254, 26);
            PageExcludedTextBox.TabIndex = 1;
            // 
            // PageCloudFlareProtectedLabel
            // 
            PageCloudFlareProtectedLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PageCloudFlareProtectedLabel.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PageCloudFlareProtectedLabel.Location = new Point(5, 81);
            PageCloudFlareProtectedLabel.Margin = new Padding(5, 0, 5, 0);
            PageCloudFlareProtectedLabel.Name = "PageCloudFlareProtectedLabel";
            PageCloudFlareProtectedLabel.Size = new Size(170, 38);
            PageCloudFlareProtectedLabel.TabIndex = 0;
            PageCloudFlareProtectedLabel.Text = "Protected by CloudFlare";
            PageCloudFlareProtectedLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PageCloudFlareProtectedComboBox
            // 
            PageCloudFlareProtectedComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PageCloudFlareProtectedComboBox.FlatStyle = FlatStyle.Popup;
            PageCloudFlareProtectedComboBox.FormattingEnabled = true;
            PageCloudFlareProtectedComboBox.Items.AddRange(new object[] { "No", "Yes" });
            PageCloudFlareProtectedComboBox.Location = new Point(180, 84);
            PageCloudFlareProtectedComboBox.Margin = new Padding(0, 4, 0, 0);
            PageCloudFlareProtectedComboBox.Name = "PageCloudFlareProtectedComboBox";
            PageCloudFlareProtectedComboBox.Size = new Size(253, 33);
            PageCloudFlareProtectedComboBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SaveButton.Location = new Point(3, 608);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(450, 40);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Save Parametters";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DeleteButton.BackColor = Color.Brown;
            DeleteButton.FlatStyle = FlatStyle.Popup;
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(3, 654);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(450, 40);
            DeleteButton.TabIndex = 7;
            DeleteButton.Text = "Delete Profile";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Controls.Add(IndexPresetAddButton, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(250, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(464, 40);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // IndexPresetAddButton
            // 
            IndexPresetAddButton.Dock = DockStyle.Fill;
            IndexPresetAddButton.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            IndexPresetAddButton.Location = new Point(426, 0);
            IndexPresetAddButton.Margin = new Padding(2, 0, 1, 0);
            IndexPresetAddButton.Name = "IndexPresetAddButton";
            IndexPresetAddButton.RightToLeft = RightToLeft.No;
            IndexPresetAddButton.Size = new Size(37, 40);
            IndexPresetAddButton.TabIndex = 4;
            IndexPresetAddButton.Text = "+";
            IndexPresetAddButton.TextAlign = ContentAlignment.TopLeft;
            IndexPresetAddButton.UseMnemonic = false;
            IndexPresetAddButton.UseVisualStyleBackColor = true;
            IndexPresetAddButton.Click += IndexPresetAddButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(418, 25);
            label2.TabIndex = 1;
            label2.Text = "Parameters";
            // 
            // ProfilesManager
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 761);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            MaximumSize = new Size(730, 800);
            MinimizeBox = false;
            MinimumSize = new Size(730, 800);
            Name = "ProfilesManager";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Profiles Manager";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilesList).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            IndexGroupBox.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            PageGroupBox.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView ProfilesList;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox IndexGroupBox;
        private TableLayoutPanel tableLayoutPanel4;
        private Label IndexParentLabel;
        private TextBox IndexParentTextBox;
        private Label IndexObjectLabel;
        private TextBox IndexObjectTextBox;
        private Label IndexParsingObjectLabel;
        private TextBox IndexParsingObjectTextBox;
        private Label IndexTemplateLinkObjectLabel;
        private TextBox IndexTemplateLinkObjectTextBox;
        private Label IndexTemplateNameObjectLabel;
        private TextBox IndexTemplateNameObjectTextBox;
        private Label IndexParsingOrderLabel;
        private ComboBox IndexParsingOrderComboBox;
        private Label IndexTitleLabel;
        private TextBox IndexTitleTextBox;
        private Label IndexImageLabel;
        private TextBox IndexImageTextBox;
        private GroupBox PageGroupBox;
        private TableLayoutPanel tableLayoutPanel5;
        private Label PageParentLabel;
        private TextBox PageParentTextBox;
        private Label PageExcludedLabel;
        private TextBox PageExcludedTextBox;
        private Label PageCloudFlareProtectedLabel;
        private ComboBox PageCloudFlareProtectedComboBox;
        private TableLayoutPanel tableLayoutPanel6;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Button SaveButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Button IndexPresetAddButton;
        private DataGridViewTextBoxColumn ColumnPresetName;
        private Button DeleteButton;
    }
}