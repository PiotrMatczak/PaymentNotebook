using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentNotebook.Enums
{
    public enum ObligationType
    {
        [DisplayLanguagePl("Zobowiązanie"), DisplayLanguageEn("Payables")]
        Payables = 0,

        [DisplayLanguagePl("Należność"), DisplayLanguageEn("Receivables")]
        Receivables = 1
    }
}
