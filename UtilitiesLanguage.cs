using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PaymentNotebook.Enums;

namespace PaymentNotebook
{
    interface IDisplayString
    {
        public string DisplayString { get; set; }
    }

    internal class DisplayLanguagePlAttribute : Attribute, IDisplayString
    {
        public string DisplayString { get; set; }

        public DisplayLanguagePlAttribute(string displayString)
        {
            DisplayString = displayString;
        }
    }
    
    internal class DisplayLanguageEnAttribute : Attribute, IDisplayString
    {
        public string DisplayString { get; set; }

        public DisplayLanguageEnAttribute(string displayString)
        {
            DisplayString = displayString;
        }
    }

    internal static class EnumAttributes
    {
        public static TAttribute GetAttribute<TAttribute>(this Enum value) where TAttribute : Attribute
        {
            Type enumType = value.GetType();
            string name = Enum.GetName(enumType, value);
            return enumType.GetField(name).GetCustomAttribute<TAttribute>();
        }
    }
}
