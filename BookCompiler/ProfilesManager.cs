using BookCompiler.Epub;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BookCompiler
{
    public partial class ProfilesManager : Form
    {
        private Form1 parent;
        private Theme currentTheme;

        public ProfilesManager(Form1 parent)
        {
            Owner = this.parent = parent;
            InitializeComponent();
            ApplyTheme();
            ProfilesList.AutoGenerateColumns = false;
            ProfilesList.DataSource = parent.presets;
        }

        private void ApplyTheme()
        {
            if (parent.currentTheme == null) { return; }
            currentTheme = parent.currentTheme;
            Theme theme = currentTheme;

            this.BackColor = theme.BackgroundColor;
            this.ForeColor = theme.ForegroundColor;

            NameLabel.ForeColor = theme.ForegroundColor;
            IndexTitleLabel.ForeColor = theme.ForegroundColor;
            IndexParentLabel.ForeColor = theme.ForegroundColor;
            IndexObjectLabel.ForeColor = theme.ForegroundColor;
            IndexParsingObjectLabel.ForeColor = theme.ForegroundColor;
            IndexTemplateLinkObjectLabel.ForeColor = theme.ForegroundColor;
            IndexTemplateNameObjectLabel.ForeColor = theme.ForegroundColor;
            IndexParsingOrderLabel.ForeColor = theme.ForegroundColor;
            IndexImageLabel.ForeColor = theme.ForegroundColor;
            PageParentLabel.ForeColor = theme.ForegroundColor;
            PageExcludedLabel.ForeColor = theme.ForegroundColor;
            PageCloudFlareProtectedLabel.ForeColor = theme.ForegroundColor;

            IndexTitleTextBox.BackColor = theme.InputBackgroundColor;
            IndexParentTextBox.BackColor = theme.InputBackgroundColor;
            IndexObjectTextBox.BackColor = theme.InputBackgroundColor;
            IndexParsingObjectTextBox.BackColor = theme.InputBackgroundColor;
            IndexTemplateLinkObjectTextBox.BackColor = theme.InputBackgroundColor;
            IndexTemplateNameObjectTextBox.BackColor = theme.InputBackgroundColor;
            IndexImageTextBox.BackColor = theme.InputBackgroundColor;
            PageParentTextBox.BackColor = theme.InputBackgroundColor;
            PageExcludedTextBox.BackColor = theme.InputBackgroundColor;

            IndexTitleTextBox.ForeColor = theme.InputForegroundColor;
            IndexParentTextBox.ForeColor = theme.InputForegroundColor;
            IndexObjectTextBox.ForeColor = theme.InputForegroundColor;
            IndexParsingObjectTextBox.ForeColor = theme.InputForegroundColor;
            IndexTemplateLinkObjectTextBox.ForeColor = theme.InputForegroundColor;
            IndexTemplateNameObjectTextBox.ForeColor = theme.InputForegroundColor;
            IndexImageTextBox.ForeColor = theme.InputForegroundColor;
            PageParentTextBox.ForeColor = theme.InputForegroundColor;
            PageExcludedTextBox.ForeColor = theme.InputForegroundColor;

            IndexParsingOrderComboBox.BackColor = theme.ButtonBackgroundColor;
            PageCloudFlareProtectedComboBox.BackColor = theme.ButtonBackgroundColor;

            IndexParsingOrderComboBox.ForeColor = theme.ButtonForegroundColor;
            PageCloudFlareProtectedComboBox.ForeColor = theme.ButtonForegroundColor;

            IndexPresetAddButton.BackColor = theme.ButtonBackgroundColor;
            IndexPresetAddButton.ForeColor = theme.ButtonForegroundColor;

            SaveButton.BackColor = theme.ButtonBackgroundColor;
            SaveButton.ForeColor = theme.ButtonForegroundColor;

            IndexPresetAddButton.BackColor = theme.ButtonBackgroundColor;
            IndexPresetAddButton.ForeColor = theme.ButtonForegroundColor;

            ProfilesList.BackgroundColor = theme.BackgroundColor;
            ProfilesList.ForeColor = theme.ForegroundColor;
            ProfilesList.DefaultCellStyle.BackColor = theme.BackgroundColor;
            ProfilesList.RowsDefaultCellStyle.BackColor = theme.BackgroundColor;
            ProfilesList.DefaultCellStyle.ForeColor = theme.ForegroundColor;
            ProfilesList.RowsDefaultCellStyle.ForeColor = theme.ForegroundColor;
        }

        private void PaintroupBox(object sender, PaintEventArgs p)
        {
            Brush back = Brushes.White;
            Brush fore = Brushes.Black;
            Brush border = Brushes.Black;
            if (currentTheme != null)
            {
                back = new SolidBrush(currentTheme.BackgroundColor);
                fore = new SolidBrush(currentTheme.ForegroundColor);
                border = new SolidBrush(currentTheme.BorderColor);
            }


            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(SystemColors.Control);
            Pen pen = new Pen(border);
            p.Graphics.FillRectangle(back, 0, 0, box.Width, box.Height);
            p.Graphics.DrawLine(pen,
                0, 11,
                0, box.Height - 5);
            p.Graphics.DrawLine(pen,
                box.Width - 5, 11,
                box.Width - 5, box.Height - 5);
            p.Graphics.DrawLine(pen,
                0, box.Height - 5,
                box.Width - 5, box.Height - 5);

            p.Graphics.DrawLine(pen,
                0, 11,
                15, 11);

            Size proposedSize = new Size(int.MaxValue, int.MaxValue);
            Size size = TextRenderer.MeasureText(p.Graphics, box.Text, box.Font, proposedSize, TextFormatFlags.NoPadding);

            float length = size.Width + 15;
            p.Graphics.DrawLine(pen,
                (16 + length), 11, box.Width - 5, 11);

            p.Graphics.DrawString(box.Text, box.Font, fore, 20, 0);
        }

        private void ProfilesList_SelectionChanged(object sender, EventArgs e)
        {
            Preset? preset = null;
            bool parsed = false;
            if (ProfilesList.SelectedRows.Count > 0)
            {
                preset = ProfilesList.SelectedRows[0].DataBoundItem as Preset;
                if (preset != null && preset.Name != null && preset.Name.Trim().Length > 0)
                {
                    parsed = true;

                    NameTextBox.Text = preset.Name;

                    IndexTitleTextBox.Text = preset.IndexTitle;
                    IndexParentTextBox.Text = preset.IndexParent;
                    IndexObjectTextBox.Text = preset.IndexObject;
                    IndexParsingObjectTextBox.Text = preset.IndexObjectRegex;
                    IndexTemplateLinkObjectTextBox.Text = preset.IndexTemplateLink;
                    IndexTemplateNameObjectTextBox.Text = preset.IndexTemplateName;
                    IndexImageTextBox.Text = preset.IndexImageObject;
                    PageParentTextBox.Text = preset.PageParent;
                    PageExcludedTextBox.Text = preset.PageExcluded;

                    IndexParsingOrderComboBox.SelectedIndex = (preset.IndexOrderDescendent) ? 1 : 0;
                    PageCloudFlareProtectedComboBox.SelectedIndex = (preset.PageProtected) ? 1 : 0;
                }
            }
            if (!parsed)
            {
                NameTextBox.Text = "";

                IndexTitleTextBox.Text = "";
                IndexParentTextBox.Text = "";
                IndexObjectTextBox.Text = "";
                IndexParsingObjectTextBox.Text = "";
                IndexTemplateLinkObjectTextBox.Text = "";
                IndexTemplateNameObjectTextBox.Text = "";
                IndexImageTextBox.Text = "";
                PageParentTextBox.Text = "";
                PageExcludedTextBox.Text = "";

                IndexParsingOrderComboBox.SelectedIndex = 0;
                PageCloudFlareProtectedComboBox.SelectedIndex = 0;
            }
        }

        private void IndexPresetAddButton_Click(object sender, EventArgs e)
        {
            if (Tools.Dialog.ShowDialog(this, "", "New Profile", Tools.DialogButton.OKCancel, Tools.DialogIcon.Info, false, null, Tools.DialogType.Input) == Tools.DialogReturn.OK)
            {
                string ret = Tools.Dialog.last_input;
                if (ret != null && ret.Trim().Length > 0)
                {
                    parent.presets.Add(new Preset() { Name = ret.Trim() });
                    parent.presets = parent.presets.OrderBy(o => o.Name).ToList();
                    ProfilesList.DataSource = parent.presets;
                    for (int i = 0; i < ProfilesList.Rows.Count; i++)
                    {
                        if (((Preset)ProfilesList.Rows[i].DataBoundItem).Name == ret)
                        {
                            ProfilesList.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ProfilesList.SelectedRows.Count == 0) { return; }
            Preset? preset = ProfilesList.SelectedRows[0].DataBoundItem as Preset;
            if (preset == null || preset.Name == null || preset.Name.Length == 0) { return; }
            string name = preset.Name.Trim();
            if (Tools.Dialog.ShowDialog(this, "Do you confirm the destruction of profile \"" + name + "\" ?", "Warning", Tools.DialogButton.YesNo, Tools.DialogIcon.Warning, false, null, Tools.DialogType.Message) == Tools.DialogReturn.Yes)
            {
                ProfilesList.DataSource = null;
                for (int i = 0; i < parent.presets.Count; i++)
                {
                    if (parent.presets[i].Name.Trim() == name) { parent.presets.RemoveAt(i); break; }
                }

                ProfilesList.DataSource = parent.presets;
                ProfilesList.Rows[0].Selected = true;

                if (((Preset)parent.IndexPresetComboBox.SelectedItem).Name == name)
                {
                    parent.IndexPresetComboBox.DataSource = null;
                    parent.IndexPresetComboBox.DataSource = parent.presets;
                    parent.IndexPresetComboBox.SelectedIndex = 0;
                }
                else
                {
                    int index = parent.IndexPresetComboBox.SelectedIndex;
                    parent.IndexPresetComboBox.DataSource = null;
                    parent.IndexPresetComboBox.DataSource = parent.presets;
                    parent.IndexPresetComboBox.SelectedIndex = index;
                }

                parent.SavePresets();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ProfilesList.SelectedRows.Count == 0) { return; }
            if (ProfilesList.SelectedRows[0].Index <= 0) { return; }
            NameTextBox.Text = NameTextBox.Text.Trim();

            Preset pr = new Preset()
            {
                Name = NameTextBox.Text,
                IndexTitle = IndexTitleTextBox.Text,
                IndexParent = IndexParentTextBox.Text,
                IndexObject = IndexObjectTextBox.Text,
                IndexObjectRegex = IndexParsingObjectTextBox.Text,
                IndexTemplateLink = IndexTemplateLinkObjectTextBox.Text,
                IndexTemplateName = IndexTemplateNameObjectTextBox.Text,
                IndexImageObject = IndexImageTextBox.Text,
                PageParent = PageParentTextBox.Text,
                PageExcluded = PageExcludedTextBox.Text,
                IndexOrderDescendent = (IndexParsingOrderComboBox.SelectedIndex > 0) ? true : false,
                PageProtected = (PageCloudFlareProtectedComboBox.SelectedIndex > 0) ? true : false,
            };
            Debug.WriteLine(JsonConvert.SerializeObject(pr));

            int index = ProfilesList.SelectedRows[0].Index;
            ProfilesList.DataSource = null;
            for (int i = 0; i < parent.presets.Count; i++)
            {
                if (parent.presets[i].Name.Trim() == pr.Name) { parent.presets[i] = pr; break; }
            }

            ProfilesList.DataSource = parent.presets;
            ProfilesList.Rows[index].Selected = true;

            index = parent.IndexPresetComboBox.SelectedIndex;
            parent.IndexPresetComboBox.DataSource = null;
            parent.IndexPresetComboBox.DataSource = parent.presets;
            parent.IndexPresetComboBox.SelectedIndex = index;

            parent.SavePresets();
        }
    }
}
