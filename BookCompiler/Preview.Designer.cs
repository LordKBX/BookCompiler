namespace BookCompiler
{
    partial class Preview
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
            tableLayoutPanel1 = new TableLayoutPanel();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel2 = new TableLayoutPanel();
            IndexLabel = new Label();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            tableLayoutPanel3 = new TableLayoutPanel();
            webView22 = new Microsoft.Web.WebView2.WinForms.WebView2();
            Page1Label = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            BtnCancel = new Button();
            BtnOK = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView22).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(splitContainer1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(784, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(5, 5);
            splitContainer1.Margin = new Padding(5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel3);
            splitContainer1.Size = new Size(774, 501);
            splitContainer1.SplitterDistance = 390;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(IndexLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(webView21, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(390, 501);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // IndexLabel
            // 
            IndexLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IndexLabel.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            IndexLabel.Location = new Point(8, 0);
            IndexLabel.Margin = new Padding(8, 0, 8, 0);
            IndexLabel.Name = "IndexLabel";
            IndexLabel.Size = new Size(374, 40);
            IndexLabel.TabIndex = 2;
            IndexLabel.Text = "Index";
            IndexLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(5, 45);
            webView21.Margin = new Padding(5);
            webView21.Name = "webView21";
            webView21.Size = new Size(380, 451);
            webView21.Source = new Uri("https://www.google.fr/", UriKind.Absolute);
            webView21.TabIndex = 3;
            webView21.ZoomFactor = 1D;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(webView22, 0, 1);
            tableLayoutPanel3.Controls.Add(Page1Label, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(5);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(381, 501);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // webView22
            // 
            webView22.AllowExternalDrop = true;
            webView22.CreationProperties = null;
            webView22.DefaultBackgroundColor = Color.White;
            webView22.Dock = DockStyle.Fill;
            webView22.Location = new Point(5, 45);
            webView22.Margin = new Padding(5);
            webView22.Name = "webView22";
            webView22.Size = new Size(371, 451);
            webView22.Source = new Uri("https://www.google.fr/", UriKind.Absolute);
            webView22.TabIndex = 4;
            webView22.ZoomFactor = 1D;
            // 
            // Page1Label
            // 
            Page1Label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Page1Label.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Page1Label.Location = new Point(8, 0);
            Page1Label.Margin = new Padding(8, 0, 8, 0);
            Page1Label.Name = "Page1Label";
            Page1Label.Size = new Size(365, 40);
            Page1Label.TabIndex = 2;
            Page1Label.Text = "Chapter 1";
            Page1Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(BtnCancel);
            flowLayoutPanel1.Controls.Add(BtnOK);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 511);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(784, 50);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // BtnCancel
            // 
            BtnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCancel.Location = new Point(666, 0);
            BtnCancel.Margin = new Padding(0);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(118, 47);
            BtnCancel.TabIndex = 0;
            BtnCancel.Text = "&Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(548, 0);
            BtnOK.Margin = new Padding(0);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(118, 47);
            BtnOK.TabIndex = 1;
            BtnOK.Text = "&OK";
            BtnOK.UseVisualStyleBackColor = true;
            // 
            // Preview
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            MinimumSize = new Size(800, 600);
            Name = "Preview";
            Text = "Preview";
            tableLayoutPanel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView22).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label IndexLabel;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TableLayoutPanel tableLayoutPanel3;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView22;
        private Label Page1Label;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button BtnCancel;
        private Button BtnOK;
    }
}