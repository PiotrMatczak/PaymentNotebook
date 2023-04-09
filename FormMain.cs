using PaymentNotebook.Enums;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using Newtonsoft.Json;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.ApplicationServices;
using PaymentNotebook.Objects;

namespace PaymentNotebook
{
    public partial class FormMain : Form
    {
        private ListViewColumnSorter lvwColumnSorter;
        public FormMain()
        {
            /*System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("En");
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = culture;*/
            InitializeComponent();
            this.lvwColumnSorter = new ListViewColumnSorter();
            overListViewTransactions.ListViewItemSorter = lvwColumnSorter;


            if (Program.fileArgs.Length > 1)
            {
                string filePath = Program.fileArgs[1];
                string deserializeString = File.ReadAllText(filePath);
                this.Text = $"{UtilitiesGeneral.GetFilenameWithoutPath(filePath)} - {Program.selectedLanguage.MainFormTextString}";
                try
                {
                    var deserializedObject = JsonConvert.DeserializeObject<ListWithCounter<Entry>>(deserializeString);
                    Program.entryList = deserializedObject;
                    openFileDialogMain.FileName = saveFileDialogMain.FileName = filePath;
                }
                catch
                {
                    MessageBox.Show(Program.selectedLanguage.DeserializeUnsuccessful, Program.selectedLanguage.ErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            refreshCurrentTab_Action(this, new EventArgs());
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshCurrentTab_Action(object sender, EventArgs e)
        {
            switch (tabControlMain.SelectedTab)
            {
                case var value when value == tabPageOverview:
                    UtilitiesGeneral.RefreshCombobox(overComboBoxContractorlist, Program.entryList.GroupBy(e => e.Name).Select(g => g.First().Name).ToList(), 0, Program.selectedLanguage.EverythingString);
                    break;
                case var value when value == tabPageEdit:
                    editComboBoxObligationtype.Items.Clear();
                    editComboBoxObligationtype.Items.AddRange(UtilitiesGeneral.ConvertIDisplayStringToObjectList<ObligationType, DisplayLanguagePlAttribute>());
                    editComboBoxPaymentstatus.Items.Clear();
                    editComboBoxPaymentstatus.Items.AddRange(UtilitiesGeneral.ConvertIDisplayStringToObjectList<PaymentStatus, DisplayLanguagePlAttribute>());
                    UtilitiesGeneral.RefreshCombobox(editComboBoxListing, Program.entryList, 0, Program.selectedLanguage.NewPositionString);
                    UtilitiesGeneral.RefreshAutocompleteName(editTextBoxName, Program.entryList);
                    break;
            }
        }

        private void overComboBoxContractorlist_Refresh(object sender, EventArgs e)
        {
            IEnumerable<Entry> displayIEnum = Program.entryList;
            if (overCheckBoxOnlypending.Checked)
            {
                displayIEnum = displayIEnum.Where(e => e.PaymentStatus == PaymentStatus.Pending);
            }

            if (overComboBoxContractorlist.SelectedIndex != 0)
            {
                displayIEnum = displayIEnum.Where(e => e.Name == overComboBoxContractorlist.SelectedItem.ToString());    //lack of ToString() breaks refreshing of overListView..
                                                                                                                         //..after adding new position in edit tab.
            }

            UtilitiesGeneral.RefreshListView(overListViewTransactions, displayIEnum.ToList(), Program.selectedLanguage.LanguageCode);

            decimal payablesSum = displayIEnum.Where(e => e.ObligationType == ObligationType.Payables).Sum(f => f.Amount);
            overTextBoxPayables.Text = payablesSum.ToString();

            decimal receivablesSum = displayIEnum.Where(e => e.ObligationType == ObligationType.Receivables).Sum(f => f.Amount);
            overTextBoxReceivables.Text = receivablesSum.ToString();

            decimal totalSum = receivablesSum - payablesSum;
            overTextBoxSum.Text = totalSum.ToString();
        }

        private void editCheckBoxTodaydate_CheckedChanged(object sender, EventArgs e)
        {
            editDateTimePickerDate.Enabled = !editCheckBoxTodaydate.Checked;
            if (editCheckBoxTodaydate.Checked)
            {
                editDateTimePickerDate.Value = DateTime.Now;
            }
        }

        private void editComboBoxListing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (editComboBoxListing.SelectedIndex == 0)
            {
                editCheckBoxTodaydate.Checked = true;
                editTextBoxId.Text = Program.entryList.CheckNextId().ToString();
                editTextBoxName.Text = string.Empty;
                editTextBoxDescription.Text = string.Empty;
                editTextBoxAmount.Text = string.Empty;
                editComboBoxObligationtype.SelectedIndex = -1;
                editComboBoxPaymentstatus.SelectedIndex = -1;
                editButtonDeleteentry.Enabled = false;
            }
            else
            {
                var entry = (Entry)(sender as ComboBox).SelectedItem;
                editTextBoxId.Text = entry.Id.ToString();
                editCheckBoxTodaydate.Checked = false;
                editTextBoxName.Text = entry.Name;
                editTextBoxDescription.Text = entry.Description;
                editTextBoxAmount.Text = entry.Amount.ToString();
                editComboBoxObligationtype.SelectedIndex = (int)entry.ObligationType;
                editComboBoxPaymentstatus.SelectedIndex = (int)entry.PaymentStatus;
                editDateTimePickerDate.Value = entry.Date;
                editButtonDeleteentry.Enabled = true;
            }
        }

        private void validateAndAddEntry_Action(object sender, EventArgs e)
        {
            if (editTextBoxName.Text == String.Empty ||
                editComboBoxObligationtype.Text == String.Empty ||
                editTextBoxAmount.Text == String.Empty ||
                editComboBoxPaymentstatus.Text == String.Empty)
            {
                MessageBox.Show(Program.selectedLanguage.FillFieldsString, Program.selectedLanguage.WarningString, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(editTextBoxAmount.Text, out decimal amount))
            {
                MessageBox.Show(Program.selectedLanguage.FillAmountFieldString, Program.selectedLanguage.WarningString, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (editComboBoxListing.SelectedIndex == 0)
            {
                Entry position = new Entry(Program.entryList.CheckNextId(), editTextBoxName.Text,
                    amount, editDateTimePickerDate.Value,
                    (ObligationType)editComboBoxObligationtype.SelectedIndex,
                    (PaymentStatus)editComboBoxPaymentstatus.SelectedIndex,
                    editTextBoxDescription.Text);

                Program.entryList.Add(position);
                MessageBox.Show(Program.selectedLanguage.EntryAddedString, Program.selectedLanguage.EntryAddedCaptionString, MessageBoxButtons.OK, MessageBoxIcon.Information);
                UtilitiesGeneral.RefreshCombobox(editComboBoxListing, Program.entryList, Program.entryList.Count, Program.selectedLanguage.NewPositionString);
            }
            else
            {
                Entry position = (Entry)editComboBoxListing.SelectedItem;
                position.Name = editTextBoxName.Text;
                position.Description = editTextBoxDescription.Text;
                position.Date = editDateTimePickerDate.Value;
                position.Amount = amount;
                position.ObligationType = (ObligationType)editComboBoxObligationtype.SelectedIndex;
                position.PaymentStatus = (PaymentStatus)editComboBoxPaymentstatus.SelectedIndex;

                MessageBox.Show(Program.selectedLanguage.EntryModifiedString, Program.selectedLanguage.EntryAddedCaptionString, MessageBoxButtons.OK, MessageBoxIcon.Information);
                UtilitiesGeneral.RefreshCombobox(editComboBoxListing, Program.entryList, editComboBoxListing.SelectedIndex, Program.selectedLanguage.NewPositionString);
            }

            UtilitiesGeneral.RefreshListView(overListViewTransactions, Program.entryList, Program.selectedLanguage.LanguageCode);
            UtilitiesGeneral.RefreshAutocompleteName(editTextBoxName, Program.entryList);
        }

        private void editButtonDeleteentry_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Program.selectedLanguage.DeleteEntryQuestionString, Program.selectedLanguage.DeleteEntryQuestionCaptionString, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Entry position = (Entry)editComboBoxListing.SelectedItem;
                Program.entryList.Remove(position);

                UtilitiesGeneral.RefreshCombobox(editComboBoxListing, Program.entryList, editComboBoxListing.SelectedIndex - 1, Program.selectedLanguage.NewPositionString);
                UtilitiesGeneral.RefreshListView(overListViewTransactions, Program.entryList, Program.selectedLanguage.LanguageCode);
            }
        }

        private void toolStripMenuItemLangselect_Click(object sender, EventArgs e)
        {
            toolStripMenuItemEn.Checked = toolStripMenuItemPl.Checked = false;
            (sender as ToolStripMenuItem).Checked = true;
            //System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo((sender as ToolStripMenuItem).Tag.ToString());
            //System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            //System.Threading.Thread.CurrentThread.CurrentUICulture = culture;
            ChangeLanguage((sender as ToolStripMenuItem).Tag.ToString());
        }

        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(FormMain));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        private void saveToFileWithDialog_Action(object sender, EventArgs e)
        {
            string serializeString = JsonConvert.SerializeObject(Program.entryList);
            if (saveFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialogMain.FileName, serializeString);
                openFileDialogMain.FileName = saveFileDialogMain.FileName;
                this.Text = $"{UtilitiesGeneral.GetFilenameWithoutPath(saveFileDialogMain.FileName)} - {Program.selectedLanguage.MainFormTextString}";
            }
        }

        private void saveQuickToFile_Action(object sender, EventArgs e)
        {
            if (openFileDialogMain.FileName != string.Empty)
            {
                string serializeString = JsonConvert.SerializeObject(Program.entryList);
                File.WriteAllText(openFileDialogMain.FileName, serializeString);
            }
            else
            {
                saveToFileWithDialog_Action(sender, e);
            }
        }

        private void openFileWithDialog_Action(object sender, EventArgs e)
        {
            SaveThenLoadMethod(DeserializeAndLoad);
        }

        internal ListWithCounter<Entry> DeserializeAndLoad()
        {
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                if (UtilitiesGeneral.JsonExtension.IsMatch(openFileDialogMain.FileName))
                {
                    string deserializeString = File.ReadAllText(openFileDialogMain.FileName);
                    this.Text = $"{UtilitiesGeneral.GetFilenameWithoutPath(openFileDialogMain.FileName)} - {Program.selectedLanguage.MainFormTextString}";
                    try
                    {
                        var deserializedObject = JsonConvert.DeserializeObject<ListWithCounter<Entry>>(deserializeString);
                        return deserializedObject;
                    }
                    catch
                    {
                        MessageBox.Show(Program.selectedLanguage.DeserializeUnsuccessful, Program.selectedLanguage.ErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
            }

            return null;
        }

        private void newWorksheet_Action(object sender, EventArgs e)
        {
            if (SaveThenLoadMethod(() => new ListWithCounter<Entry>()))
                this.Text = $"{UtilitiesGeneral.GetFilenameWithoutPath(Program.selectedLanguage.NewWorksheetString)} - {Program.selectedLanguage.MainFormTextString}";
        }

        internal bool SaveThenLoadMethod(Func<ListWithCounter<Entry>> funcDelegate)
        {
            DialogResult decision = MessageBox.Show(Program.selectedLanguage.SaveBeforeQuestionString, Program.selectedLanguage.WarningString, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

            if (decision != DialogResult.Cancel)
            {
                if (decision == DialogResult.Yes)
                {
                    if (openFileDialogMain.FileName != string.Empty)
                    {
                        string serializeString = JsonConvert.SerializeObject(Program.entryList);
                        File.WriteAllText(openFileDialogMain.FileName, serializeString);
                        if (funcDelegate == null)
                            return true;
                        ListWithCounter<Entry> loadedList = funcDelegate();
                        if (loadedList != null)
                        {
                            Program.entryList = loadedList;
                            refreshCurrentTab_Action(this, new EventArgs());
                            return true;
                        }
                        else
                            return false;
                    }
                    else
                    {
                        if (saveFileDialogMain.ShowDialog() == DialogResult.OK)
                        {
                            string serializeString = JsonConvert.SerializeObject(Program.entryList);
                            File.WriteAllText(saveFileDialogMain.FileName, serializeString);
                            openFileDialogMain.FileName = saveFileDialogMain.FileName;
                            if (funcDelegate == null)
                                return true;
                            ListWithCounter<Entry> loadedList = funcDelegate();
                            if (loadedList != null)
                            {
                                Program.entryList = loadedList;
                                refreshCurrentTab_Action(this, new EventArgs());
                                return true;
                            }
                            else
                                return false;
                        }
                        else
                            return false;
                    }
                }
                else
                {
                    if (funcDelegate == null)
                        return true;
                    ListWithCounter<Entry> loadedList = funcDelegate();
                    if (loadedList != null)
                    {
                        Program.entryList = loadedList;
                        refreshCurrentTab_Action(this, new EventArgs());
                        return true;
                    }
                    else
                        return false;
                }
            }
            else
                return false;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!SaveThenLoadMethod(null))
                e.Cancel = true;
        }

        private void AboutBoxShow_Action(object sender, EventArgs e)
        {
            AboutBoxMain aboutBoxMain = new AboutBoxMain();
            aboutBoxMain.ShowDialog();
        }

        private void overListViewTransactions_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.overListViewTransactions.Sort();
        }
    }
}