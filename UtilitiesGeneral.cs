using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PaymentNotebook.Enums;

namespace PaymentNotebook
{
    public static class UtilitiesGeneral
    {
        public static Regex JsonExtension { get; } = new Regex(@"\.json$", RegexOptions.IgnoreCase);

        internal static string GetFilenameWithoutPath(string filenamePath)
        {
            return new Regex(@"[^\\]+$", RegexOptions.IgnoreCase).Match(filenamePath).Value;
        }

        internal static void RefreshCombobox<T>(ComboBox combobox, List<T> source, int showIndex, string addFirstPosition = "") where T : class
        {
            combobox.Items.Clear();
            combobox.Items.Add(addFirstPosition);
            combobox.Items.AddRange(source.ToArray());
            combobox.SelectedIndex = showIndex;
        }

        internal static void RefreshAutocompleteName(TextBox textbox, List<Entry> source)
        {
            AutoCompleteStringCollection nameSuggestion = new AutoCompleteStringCollection();
            nameSuggestion.AddRange(source.Select((Entry e) => e.Name).ToArray());
            textbox.AutoCompleteCustomSource = nameSuggestion;
        }

        internal static ListViewItem[] GetListViewItemArray(List<Entry> source, LanguageCode languageCode)
        {
            List<ListViewItem> listView = new List<ListViewItem>();
            {
                foreach (Entry entry in source)
                {
                    string obligationTypeString, paymentStatusString;
                    switch (Program.selectedLanguage.LanguageCode)
                    {
                        default:
                        case LanguageCode.Pl:
                            obligationTypeString = entry.ObligationType.GetAttribute<DisplayLanguagePlAttribute>().DisplayString;
                            paymentStatusString = entry.PaymentStatus.GetAttribute<DisplayLanguagePlAttribute>().DisplayString;
                            break;
                        case LanguageCode.En:
                            obligationTypeString = entry.ObligationType.GetAttribute<DisplayLanguageEnAttribute>().DisplayString;
                            paymentStatusString = entry.PaymentStatus.GetAttribute<DisplayLanguageEnAttribute>().DisplayString;
                            break;
                    }

                    ListViewItem pos = new ListViewItem(new string[] {
                        entry.Id.ToString(),
                        entry.Date.ToShortDateString(),
                        entry.Name,
                        entry.Description,
                        obligationTypeString,
                        entry.Amount.ToString(),
                        paymentStatusString });

                    listView.Add(pos);
                }
                return listView.ToArray();
            }
        }

        internal static void RefreshListView(ListView listView, List<Entry> source, LanguageCode languageCode)
        {
            listView.Items.Clear();
            listView.Items.AddRange(GetListViewItemArray(source, languageCode));
        }

        internal static object[] ConvertIDisplayStringToObjectList<TEnum, TAttribute>() where TEnum : Enum where TAttribute : Attribute, IDisplayString
        {
            List<object> objectList = new List<object>();

            foreach (TEnum enumValue in Enum.GetValues(typeof(TEnum)))
            {
                objectList.Add(enumValue.GetAttribute<TAttribute>().DisplayString.ToString());
            }

            return objectList.ToArray();
        }
    }
}
