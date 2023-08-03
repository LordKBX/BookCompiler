namespace BookCompiler
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            VersionLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(484, 461);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.icon;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Dock = DockStyle.Fill;
            button1.Enabled = false;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 94);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(VersionLabel, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(103, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.Size = new Size(378, 94);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(372, 42);
            label1.TabIndex = 2;
            label1.Text = "BookCompiler";
            // 
            // VersionLabel
            // 
            VersionLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            VersionLabel.AutoSize = true;
            VersionLabel.Font = new Font("Yu Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            VersionLabel.Location = new Point(3, 70);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(372, 18);
            VersionLabel.TabIndex = 2;
            VersionLabel.Text = "Version label";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 103);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(478, 355);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(470, 25);
            label2.TabIndex = 2;
            label2.Text = "Author: LordKBX";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 25);
            label3.Name = "label3";
            label3.Size = new Size(252, 25);
            label3.TabIndex = 3;
            label3.Text = "Creation Date: 2023/07/27";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 50);
            label4.Name = "label4";
            label4.Size = new Size(176, 25);
            label4.TabIndex = 3;
            label4.Text = "Licence: Type BSD";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 78);
            textBox1.MinimumSize = new Size(470, 268);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(470, 268);
            textBox1.TabIndex = 4;
            textBox1.Text = "Licence text";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            MaximumSize = new Size(500, 500);
            MinimizeBox = false;
            MinimumSize = new Size(500, 500);
            Name = "About";
            Text = "About";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label VersionLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
    }
}