using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentNotebook.Enums
{
    public enum PaymentStatus
    {
        [DisplayLanguagePl("Oczekująca"), DisplayLanguageEn("Pending")]
        Pending = 0,

        [DisplayLanguagePl("Zakończona"), DisplayLanguageEn("Completed")]
        Completed = 1
    }
}
