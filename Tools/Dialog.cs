using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Tools
{
    [ComVisible(true)]
    public class Dialog
    {
        [ComVisible(true)]
        public static string last_input = null;
        private static Form form = null;
        private static DialogReturn lastReturn = DialogReturn.None;
        private static Dictionary<DialogButton, List<DialogReturn>> DialogButtonsOrder = new Dictionary<DialogButton, List<DialogReturn>>() {
            { DialogButton.OK, new List<DialogReturn>() { DialogReturn.OK } },
            { DialogButton.OKCancel, new List<DialogReturn>() { DialogReturn.Cancel, DialogReturn.OK } },
            { DialogButton.AbortRetryIgnore, new List<DialogReturn>() { DialogReturn.Ignore, DialogReturn.Retry, DialogReturn.Abort } } ,
            { DialogButton.YesNoCancel, new List<DialogReturn>() { DialogReturn.Cancel, DialogReturn.No, DialogReturn.Yes } },
            { DialogButton.YesNo, new List<DialogReturn>() { DialogReturn.No, DialogReturn.Yes } },
            { DialogButton.RetryCancel, new List<DialogReturn>() { DialogReturn.Cancel, DialogReturn.Retry } }
        };
        private static Dictionary<DialogReturn, string> DialogButtonsText = new Dictionary<DialogReturn, string>() {
            { DialogReturn.OK, "Ok" },
            { DialogReturn.Cancel, "Cancel" },
            { DialogReturn.Ignore, "Ignore" },
            { DialogReturn.Retry, "Retry" },
            { DialogReturn.Abort, "Abort" },
            { DialogReturn.Yes, "Yes" },
            { DialogReturn.No, "No" }
        };
        [ComVisible(true)]
        public static void UpdateDialogButton(Dictionary<DialogReturn, string> dico) {
            foreach(KeyValuePair<DialogReturn, string> kvp in dico)
            {
                DialogButtonsText[kvp.Key] = kvp.Value;
            }
        }

        private static Color titleBarForeColor = Color.FromArgb(225, 225, 225);
        private static Color titleBarBackColor = Color.FromArgb(0, 0, 0);
        private static Color AltBackgroundColor = Color.FromArgb(240, 240, 240);

        private static List<Button> btns = null;
        private static List<DialogReturn> buttonsList = null;

        [ComVisible(true)]
        public static DialogReturn ShowDialog(string message) { return ShowDialog(null, message, message, DialogButton.OK); }
        [ComVisible(true)]
        public static DialogReturn ShowDialog(string message, string title) { return ShowDialog(null, message, title, DialogButton.OK); }
        [ComVisible(true)]
        public static DialogReturn ShowDialog(string message, DialogButton buttons = DialogButton.OK, DialogIcon icon = DialogIcon.Info, bool topMost = false, string[] CustomButtonsText = null, DialogType dtype = DialogType.Message) { return ShowDialog(null, message, message, buttons, icon, topMost, CustomButtonsText, dtype); }
        [ComVisible(true)]
        public static DialogReturn ShowDialog(Form parent, string message, string title, DialogButton buttons = DialogButton.OK, DialogIcon icon = DialogIcon.Info, bool topMost = false, string[] CustomButtonsText = null, DialogType dtype = DialogType.Message)
        {
            if (form != null) { return DialogReturn.None; }
            form = new Form();
            if (parent != null) { form.Owner = parent; }
            form.Width = 410;
            form.Height = 170;
            form.StartPosition = FormStartPosition.CenterParent;
            form.BackColor = Colors.Black;
            form.Text = title;
            form.ShowIcon = false;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.ControlBox = false;
            form.TopMost = topMost;
            form.BackColor = titleBarBackColor;
            form.Padding = new Padding(1);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Font = Colors.GlobalFont;

            TableLayoutPanel panel = new TableLayoutPanel();
            panel.RightToLeft = RightToLeft.No;
            panel.ColumnCount = 2;
            panel.RowCount = 3;
            panel.BackColor = Colors.White;
            panel.Margin = new Padding(0);
            panel.Padding = new Padding(0);
            panel.Font = Colors.GlobalFont;

            Label titleLabel = new Label();
            titleLabel.Text = title.Replace("\r", "").Replace("\n", ". ").Replace("\t", "  ");
            titleLabel.Font = Colors.GlobalFont;
            titleLabel.MinimumSize = new Size(400, 30);
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            titleLabel.Anchor = AnchorStyles.Left;
            titleLabel.ForeColor = titleBarForeColor;
            titleLabel.BackColor = titleBarBackColor;
            titleLabel.Margin = new Padding(0);
            titleLabel.Padding = new Padding(0);
            titleLabel.AutoEllipsis = true;
            titleLabel.MouseDown += TitleLabel_MouseDown;
            titleLabel.MouseMove += TitleLabel_MouseMove;
            panel.Controls.Add(titleLabel, 0, 0);
            panel.SetColumnSpan(titleLabel, 2);
            titleLabel.Dock = DockStyle.Fill;

            Button iconButton = new Button();
            panel.Controls.Add(iconButton, 0, 1);
            panel.SetColumnSpan(iconButton, 1);
            iconButton.Dock = DockStyle.Fill;
            iconButton.Enabled = false;
            iconButton.FlatStyle = FlatStyle.Flat;
            iconButton.FlatAppearance.BorderColor = Color.White;
            iconButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            iconButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            iconButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            iconButton.BackColor = Color.Transparent;
            if (icon == DialogIcon.Info) { iconButton.BackgroundImage = Properties.Resources.dialog_info; }
            else if (icon == DialogIcon.Warning) { iconButton.BackgroundImage = Properties.Resources.dialog_warning; }
            else { iconButton.BackgroundImage = Properties.Resources.dialog_error; }

            iconButton.BackgroundImageLayout = ImageLayout.Zoom;
            iconButton.Margin = new Padding(25, 0, 10, 0);

            if (dtype == DialogType.Message)
            {
                Label messageLabel = new Label();
                messageLabel.Text = message;
                messageLabel.Font = Colors.GlobalFont;
                messageLabel.AutoSize = true;
                messageLabel.Anchor = AnchorStyles.Left;
                panel.Controls.Add(messageLabel, 1, 1);
                panel.SetColumnSpan(messageLabel, 1);
            }
            else if (dtype == DialogType.Input || dtype == DialogType.Password)
            {
                last_input = null;
                TextBox inputTextBox = new TextBox();
                inputTextBox.Text = message;
                inputTextBox.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                inputTextBox.MaximumSize = new Size(99999999, 400);
                inputTextBox.MinimumSize = new Size(300, 30);
                inputTextBox.Font = Colors.GlobalFont;
                if (dtype == DialogType.Password) { inputTextBox.PasswordChar = '*'; }
                inputTextBox.TextChanged += (object sender, EventArgs e) => { TextBox s = (TextBox)sender; last_input = s.Text; };
                panel.Controls.Add(inputTextBox, 1, 1);
                panel.SetColumnSpan(inputTextBox, 1);
                inputTextBox.KeyUp += (object sender, KeyEventArgs e) => {
                    if(e.KeyCode == Keys.Enter) {
                        TextBox s = (TextBox)sender;
                        last_input = s.Text;
                        if (form == null) { return; }
                        lastReturn = DialogReturn.OK;
                        form.Close();
                        form.Dispose();
                        form = null;
                    }
                };
            }

            FlowLayoutPanel lp = new FlowLayoutPanel();
            lp.BackColor = Color.Transparent;
            lp.FlowDirection = FlowDirection.RightToLeft;
            panel.Controls.Add(lp, 0, 2);
            panel.SetColumnSpan(lp, 2);
            lp.Dock = DockStyle.Fill;

            btns = new List<Button>();
            buttonsList = DialogButtonsOrder[buttons];

            int nbtn = 0;
            foreach (DialogReturn dr in buttonsList)
            {
                btns.Add(new Button());
                btns[btns.Count - 1].RightToLeft = RightToLeft.No;
                string tx = "&" + DialogButtonsText[dr];
                if (CustomButtonsText != null)
                {
                    if (CustomButtonsText.Length - 1 - nbtn >= 0)
                    {
                        tx = CustomButtonsText[CustomButtonsText.Length - 1 - nbtn];
                    }
                }
                if (tx.Length > 11) { tx = tx.Substring(0, 10) + "..."; }

                btns[btns.Count - 1].Text = tx;
                btns[btns.Count - 1].Font = Colors.GlobalFont;
                btns[btns.Count - 1].Tag = dr;
                btns[btns.Count - 1].Anchor = AnchorStyles.Right;
                btns[btns.Count - 1].MaximumSize = new Size(80, 40);
                btns[btns.Count - 1].MinimumSize = new Size(80, 40);
                btns[btns.Count - 1].Size = new Size(80, 40);
                btns[btns.Count - 1].Click += Btn_Click;
                lp.Controls.Add(btns[btns.Count - 1]);
                nbtn += 1;
            }

            form.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;

            panel.ColumnStyles.Add(new ColumnStyle());
            panel.ColumnStyles.Add(new ColumnStyle());
            panel.RowStyles.Add(new RowStyle());
            panel.RowStyles.Add(new RowStyle());
            panel.RowStyles.Add(new RowStyle());
            panel.ColumnStyles[0].Width = 75;
            panel.ColumnStyles[0].SizeType = SizeType.Absolute;
            panel.ColumnStyles[1].Width = 100;
            panel.ColumnStyles[1].SizeType = SizeType.Percent;
            panel.RowStyles[0].Height = 30;
            panel.RowStyles[0].SizeType = SizeType.Absolute;
            panel.RowStyles[1].Height = 85;
            panel.RowStyles[1].SizeType = SizeType.Absolute;
            panel.RowStyles[2].Height = 100;
            panel.RowStyles[2].SizeType = SizeType.Percent;

            form.ShowDialog();
            return lastReturn;
        }

        private static Point MouseDownLocation;

        private static void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private static void TitleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                form.Left = e.X + form.Left - MouseDownLocation.X;
                form.Top = e.Y + form.Top - MouseDownLocation.Y;
            }
        }

        private static void Panel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row == 0)
            {
                e.Graphics.FillRectangle(new SolidBrush(titleBarBackColor), e.CellBounds);
            }
            else if (e.Row == 2)
            {
                e.Graphics.FillRectangle(new SolidBrush(AltBackgroundColor), e.CellBounds);
            }
        }

        private static void Btn_Click(object sender, EventArgs e)
        {
            if (form == null) { return; }
            lastReturn = (DialogReturn)((Button)sender).Tag;
            form.Close();
            form.Dispose();
            form = null;
        }
    }

    [ComVisible(true)]
    public enum DialogType
    {
        Message,
        Input,
        Password
    }

    [ComVisible(true)]
    public enum DialogReturn
    {
        None,
        OK,
        Cancel,
        Abort,
        Retry,
        Ignore,
        Yes,
        No
    }

    [ComVisible(true)]
    public enum DialogIcon
    {
        Info,
        Warning,
        Error
    }

    [ComVisible(true)]
    public enum DialogButton
    {
        OK,
        OKCancel,
        AbortRetryIgnore,
        YesNoCancel,
        YesNo,
        RetryCancel
    }
}
