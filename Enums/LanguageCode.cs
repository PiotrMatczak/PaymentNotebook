using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentNotebook.Enums
{
    public enum LanguageCode
    {
        [DisplayLanguagePl("Polski"), DisplayLanguageEn("Polish")]
        Pl = 0,

        [DisplayLanguagePl("Angielski"), DisplayLanguageEn("English")]
        En = 1
    }
}
