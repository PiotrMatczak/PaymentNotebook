using Newtonsoft.Json;
using PaymentNotebook.Enums;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace PaymentNotebook
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    internal class ListWithCounter<T> : List<T> where T : IEntries
    {
        private int _counter = 1;
        public new void AddRange(IEnumerable<T> collection)
        {
            base.AddRange(collection);
            _counter = collection.Select(T => T.Id).Max() + 1;
        }

        public new void Add(T item)
        {
            base.Add(item);
            _counter++;
        }

        public int CheckNextId()
        {
            return _counter;
        }
    }

    interface IEntries
    {
        int Id { get; init; }
    }

    internal class Entry : IEntries
    {
        public int Id { get; init; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ObligationType ObligationType { get; set; }
        public decimal Amount { get; set; }
        public PaymentStatus PaymentStatus { get; set; }

        public Entry(int id, string name, decimal amount, DateTime dateTime, ObligationType obligationType, PaymentStatus paymentStatus, string description = "")
        {
            this.Id = id;
            this.Name = name;
            this.Amount = amount;
            this.Date = dateTime;
            this.ObligationType = obligationType;
            this.PaymentStatus = paymentStatus;
            this.Description = description;
        }

        public override string ToString()
        {
            if (Description != "")
            {
                return $"{Id}: {Name} - {Description}";
            }
            else
            {
                return $"{Id}: {Name}";
            }
        }
    }

    internal class Subentry : IEntries
    {
        public int Id { get; init; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ObligationType ObligationType { get; set; }
        public decimal Amount { get; set; }
    }

    internal static class Program
    {
        public static ILanguageData selectedLanguage = new LanguageData.LanguagePl();
        public static ListWithCounter<Entry> entryList = new ListWithCounter<Entry>();
        public static string[] fileArgs;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            fileArgs = Environment.GetCommandLineArgs();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}