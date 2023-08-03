namespace BookCompiler
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            UrlButton = new Button();
            UrlBox = new TextBox();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            OutputTextBox = new TextBox();
            ProcessButton = new Button();
            PreviewButton = new Button();
            PageGroupBox = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            PageParentLabel = new Label();
            PageParentTextBox = new TextBox();
            PageExcludedLabel = new Label();
            PageExcludedTextBox = new TextBox();
            PageCloudFlareProtectedLabel = new Label();
            PageCloudFlareProtectedComboBox = new ComboBox();
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
            tableLayoutPanel6 = new TableLayoutPanel();
            IndexPresetComboBox = new ComboBox();
            IndexPresetLabel = new Label();
            IndexPresetAddButton = new Button();
            menuStrip1 = new MenuStrip();
            themesToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            blackToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            PageGroupBox.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            IndexGroupBox.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            menuStrip1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.Black;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 35);
            splitContainer1.Margin = new Padding(8);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel1MinSize = 350;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(OutputTextBox);
            splitContainer1.Panel2.Controls.Add(ProcessButton);
            splitContainer1.Panel2.Controls.Add(PreviewButton);
            splitContainer1.Panel2.Controls.Add(PageGroupBox);
            splitContainer1.Panel2.Controls.Add(IndexGroupBox);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel6);
            splitContainer1.Panel2.Padding = new Padding(5, 0, 3, 0);
            splitContainer1.Panel2MinSize = 200;
            splitContainer1.Size = new Size(934, 776);
            splitContainer1.SplitterDistance = 524;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(webView, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(8);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(524, 776);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(UrlButton, 0, 0);
            tableLayoutPanel2.Controls.Add(UrlBox, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(524, 40);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // UrlButton
            // 
            UrlButton.BackgroundImageLayout = ImageLayout.Zoom;
            UrlButton.Dock = DockStyle.Fill;
            UrlButton.Font = new Font("Segoe MDL2 Assets", 17F, FontStyle.Regular, GraphicsUnit.Point);
            UrlButton.Location = new Point(1, 0);
            UrlButton.Margin = new Padding(1, 0, 0, 1);
            UrlButton.Name = "UrlButton";
            UrlButton.Size = new Size(39, 39);
            UrlButton.TabIndex = 0;
            UrlButton.Text = "";
            UrlButton.UseVisualStyleBackColor = true;
            UrlButton.Click += UrlButton_Click;
            // 
            // UrlBox
            // 
            UrlBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UrlBox.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            UrlBox.Location = new Point(40, 1);
            UrlBox.Margin = new Padding(0);
            UrlBox.Name = "UrlBox";
            UrlBox.PlaceholderText = "Novel Index Page URL";
            UrlBox.Size = new Size(484, 37);
            UrlBox.TabIndex = 1;
            UrlBox.KeyUp += UrlBox_KeyUp;
            // 
            // webView
            // 
            webView.AllowExternalDrop = false;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Dock = DockStyle.Fill;
            webView.Location = new Point(2, 40);
            webView.Margin = new Padding(2, 0, 0, 0);
            webView.Name = "webView";
            webView.Size = new Size(522, 736);
            webView.Source = new Uri("https://www.google.fr", UriKind.Absolute);
            webView.TabIndex = 1;
            webView.ZoomFactor = 1D;
            // 
            // OutputTextBox
            // 
            OutputTextBox.Dock = DockStyle.Top;
            OutputTextBox.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            OutputTextBox.Location = new Point(5, 680);
            OutputTextBox.MinimumSize = new Size(0, 130);
            OutputTextBox.Multiline = true;
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.ScrollBars = ScrollBars.Vertical;
            OutputTextBox.Size = new Size(399, 130);
            OutputTextBox.TabIndex = 7;
            OutputTextBox.Text = "Null";
            // 
            // ProcessButton
            // 
            ProcessButton.Dock = DockStyle.Top;
            ProcessButton.Location = new Point(5, 630);
            ProcessButton.MinimumSize = new Size(0, 50);
            ProcessButton.Name = "ProcessButton";
            ProcessButton.Size = new Size(399, 50);
            ProcessButton.TabIndex = 6;
            ProcessButton.Text = "Compile content in Temp dir";
            ProcessButton.UseVisualStyleBackColor = true;
            ProcessButton.Click += ProcessButton_Click;
            // 
            // PreviewButton
            // 
            PreviewButton.Dock = DockStyle.Top;
            PreviewButton.Location = new Point(5, 580);
            PreviewButton.Margin = new Padding(3, 10, 3, 3);
            PreviewButton.MinimumSize = new Size(0, 50);
            PreviewButton.Name = "PreviewButton";
            PreviewButton.Size = new Size(399, 50);
            PreviewButton.TabIndex = 5;
            PreviewButton.Text = "Scrape Website";
            PreviewButton.UseVisualStyleBackColor = true;
            PreviewButton.Click += PreviewButton_Click;
            // 
            // PageGroupBox
            // 
            PageGroupBox.Controls.Add(tableLayoutPanel5);
            PageGroupBox.Dock = DockStyle.Top;
            PageGroupBox.Location = new Point(5, 410);
            PageGroupBox.Margin = new Padding(3, 3, 3, 10);
            PageGroupBox.MinimumSize = new Size(0, 170);
            PageGroupBox.Name = "PageGroupBox";
            PageGroupBox.Size = new Size(399, 170);
            PageGroupBox.TabIndex = 4;
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
            tableLayoutPanel5.Size = new Size(393, 134);
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
            PageParentTextBox.Size = new Size(203, 26);
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
            PageExcludedTextBox.Size = new Size(203, 26);
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
            PageCloudFlareProtectedComboBox.Size = new Size(203, 33);
            PageCloudFlareProtectedComboBox.TabIndex = 1;
            // 
            // IndexGroupBox
            // 
            IndexGroupBox.AutoSize = true;
            IndexGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            IndexGroupBox.BackColor = Color.Transparent;
            IndexGroupBox.Controls.Add(tableLayoutPanel4);
            IndexGroupBox.Dock = DockStyle.Top;
            IndexGroupBox.ForeColor = Color.Black;
            IndexGroupBox.Location = new Point(5, 40);
            IndexGroupBox.MinimumSize = new Size(0, 370);
            IndexGroupBox.Name = "IndexGroupBox";
            IndexGroupBox.Size = new Size(399, 370);
            IndexGroupBox.TabIndex = 0;
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
            tableLayoutPanel4.Size = new Size(393, 334);
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
            IndexParentTextBox.Size = new Size(203, 26);
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
            IndexObjectTextBox.Size = new Size(203, 26);
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
            IndexParsingObjectTextBox.Size = new Size(203, 26);
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
            IndexTemplateLinkObjectTextBox.Size = new Size(203, 26);
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
            IndexTemplateNameObjectTextBox.Size = new Size(203, 26);
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
            IndexParsingOrderComboBox.Size = new Size(203, 33);
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
            IndexTitleTextBox.Size = new Size(203, 26);
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
            IndexImageTextBox.Size = new Size(203, 26);
            IndexImageTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.Controls.Add(IndexPresetComboBox, 0, 0);
            tableLayoutPanel6.Controls.Add(IndexPresetLabel, 0, 0);
            tableLayoutPanel6.Controls.Add(IndexPresetAddButton, 2, 0);
            tableLayoutPanel6.Dock = DockStyle.Top;
            tableLayoutPanel6.Location = new Point(5, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(399, 40);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // IndexPresetComboBox
            // 
            IndexPresetComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            IndexPresetComboBox.FlatStyle = FlatStyle.Popup;
            IndexPresetComboBox.FormattingEnabled = true;
            IndexPresetComboBox.Location = new Point(179, 4);
            IndexPresetComboBox.Margin = new Padding(0, 4, 10, 0);
            IndexPresetComboBox.Name = "IndexPresetComboBox";
            IndexPresetComboBox.Size = new Size(169, 33);
            IndexPresetComboBox.TabIndex = 2;
            // 
            // IndexPresetLabel
            // 
            IndexPresetLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IndexPresetLabel.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            IndexPresetLabel.Location = new Point(5, 1);
            IndexPresetLabel.Margin = new Padding(5, 0, 5, 0);
            IndexPresetLabel.Name = "IndexPresetLabel";
            IndexPresetLabel.Size = new Size(169, 38);
            IndexPresetLabel.TabIndex = 1;
            IndexPresetLabel.Text = "Profile";
            IndexPresetLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IndexPresetAddButton
            // 
            IndexPresetAddButton.Dock = DockStyle.Fill;
            IndexPresetAddButton.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            IndexPresetAddButton.Location = new Point(360, 0);
            IndexPresetAddButton.Margin = new Padding(2, 0, 1, 0);
            IndexPresetAddButton.Name = "IndexPresetAddButton";
            IndexPresetAddButton.RightToLeft = RightToLeft.No;
            IndexPresetAddButton.Size = new Size(38, 40);
            IndexPresetAddButton.TabIndex = 3;
            IndexPresetAddButton.Text = "+";
            IndexPresetAddButton.TextAlign = ContentAlignment.TopLeft;
            IndexPresetAddButton.UseMnemonic = false;
            IndexPresetAddButton.UseVisualStyleBackColor = true;
            IndexPresetAddButton.Click += IndexPresetAddButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { themesToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(934, 35);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // themesToolStripMenuItem
            // 
            themesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearToolStripMenuItem, blackToolStripMenuItem });
            themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            themesToolStripMenuItem.Size = new Size(95, 29);
            themesToolStripMenuItem.Text = "Themes";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Checked = true;
            clearToolStripMenuItem.CheckState = CheckState.Checked;
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(133, 30);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // blackToolStripMenuItem
            // 
            blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            blackToolStripMenuItem.Size = new Size(133, 30);
            blackToolStripMenuItem.Text = "Black";
            blackToolStripMenuItem.Click += blackToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(76, 29);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 251F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 31);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(241, 38);
            label1.TabIndex = 0;
            label1.Text = "Preset index parser";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(251, 50);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "div.aa";
            textBox1.Size = new Size(1, 37);
            textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 811);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            MinimumSize = new Size(950, 850);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            PageGroupBox.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            IndexGroupBox.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button UrlButton;
        private TextBox UrlBox;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem themesToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private GroupBox IndexGroupBox;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox IndexParentTextBox;
        private Label IndexParentLabel;
        private Label IndexObjectLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private TextBox textBox1;
        private TextBox IndexObjectTextBox;
        private Label IndexParsingObjectLabel;
        private TextBox IndexParsingObjectTextBox;
        private Label IndexTemplateLinkObjectLabel;
        private TextBox IndexTemplateLinkObjectTextBox;
        private Label IndexTemplateNameObjectLabel;
        private TextBox IndexTemplateNameObjectTextBox;
        private Label IndexParsingOrderLabel;
        private ComboBox IndexParsingOrderComboBox;
        private Button ProcessButton;
        private Button PreviewButton;
        private TextBox OutputTextBox;
        private GroupBox PageGroupBox;
        private TableLayoutPanel tableLayoutPanel5;
        private Label PageParentLabel;
        private TextBox PageParentTextBox;
        private Label PageExcludedLabel;
        private TextBox PageExcludedTextBox;
        private ComboBox PageCloudFlareProtectedComboBox;
        private TableLayoutPanel tableLayoutPanel6;
        private Label IndexPresetLabel;
        private Label IndexTitleLabel;
        private TextBox IndexTitleTextBox;
        private Label PageCloudFlareProtectedLabel;
        private Label IndexImageLabel;
        private TextBox IndexImageTextBox;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem blackToolStripMenuItem;
        private Button IndexPresetAddButton;
        public ComboBox IndexPresetComboBox;
    }
}