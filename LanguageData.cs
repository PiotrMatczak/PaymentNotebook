using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentNotebook.Enums;

namespace PaymentNotebook
{
    interface ILanguageData
    {
        LanguageCode LanguageCode { get; }
        string MainFormTextString { get; }
        string EverythingString { get; }
        string NewPositionString { get; }
        string WarningString { get; }
        string ErrorString { get; }
        string FillFieldsString { get; }
        string FillAmountFieldString { get; }
        string EntryAddedString { get; }
        string EntryAddedCaptionString { get; }
        string EntryModifiedString { get; }
        string EntryModifiedCaptionString { get; }
        string DeleteEntryQuestionString { get; }
        string DeleteEntryQuestionCaptionString { get; }
        string SaveBeforeQuestionString { get; }
        string DeserializeUnsuccessful { get; }
        string NewWorksheetString { get; }
        string AboutProgramString { get; }
        string VersionString { get; }
    }
    
    public class LanguageData
    {
        public class LanguagePl : ILanguageData
        {
            public LanguageCode LanguageCode { get; } = LanguageCode.Pl;
            public string MainFormTextString { get; } = "Notatnik Płatności";
            public string EverythingString { get; } = "<wszystko>";
            public string NewPositionString { get; } = "<nowa pozycja>";
            public string WarningString { get; } = "Uwaga";
            public string ErrorString { get; } = "Błąd";
            public string FillFieldsString { get; } = "Wypełnij wymagane pola";
            public string FillAmountFieldString { get; } = "W pole \"Kwota\" wpisz warość liczbową";
            public string EntryAddedString { get; } = "Dodano nowy wpis";
            public string EntryAddedCaptionString { get; } = "Wpis dodany";
            public string EntryModifiedString { get; } = "Wpis został zmodyfikowany";
            public string EntryModifiedCaptionString { get; } = "Wpis zmieniony";
            public string DeleteEntryQuestionString { get; } = "Usunąć wybraną pozycję?";
            public string DeleteEntryQuestionCaptionString { get; } = "Usuwanie wpisu";
            public string SaveBeforeQuestionString { get; } = "Zapisać arkusz przed jego zamknięciem?";
            public string DeserializeUnsuccessful { get; } = "Nie udało się poprawnie wczytać pliku";
            public string NewWorksheetString { get; } = "Nowy arkusz";
            public string AboutProgramString { get; } = "O programie";
            public string VersionString { get; } = "Wersja";
        }

        public class LanguageEn : ILanguageData
        {
            public LanguageCode LanguageCode { get; } = LanguageCode.En;
            public string MainFormTextString { get; } = "Payment Notebook";
            public string EverythingString { get; } = "<everything>";
            public string NewPositionString { get; } = "<new position>";
            public string WarningString { get; } = "Warning";
            public string ErrorString { get; } = "Error";
            public string FillFieldsString { get; } = "Fill required fields";
            public string FillAmountFieldString { get; } = "Put numeric value into \"Amount\" field";
            public string EntryAddedString { get; } = "New entry added";
            public string EntryAddedCaptionString { get; } = "Entry added";
            public string EntryModifiedString { get; } = "Entry has been modified";
            public string EntryModifiedCaptionString { get; } = "Entry changed";
            public string DeleteEntryQuestionString { get; } = "Delete selected entry?";
            public string DeleteEntryQuestionCaptionString { get; } = "Deleting entry";
            public string SaveBeforeQuestionString { get; } = "Save worksheet before closing?";
            public string DeserializeUnsuccessful { get; } = "Could not successfully load file";
            public string NewWorksheetString { get; } = "New worksheet";
            public string AboutProgramString { get; } = "About program";
            public string VersionString { get; } = "Version";
        }
    }
}
