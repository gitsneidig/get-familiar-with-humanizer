using System;
using Humanizer;

namespace humanizer_library
{
    class Program
    {
        static void Main(string[] args)
        {
            //HumanizeDateTime();
            //HumanizeSummary();
            //HumanizeNumbers();
            //HumanizeNumbersToOrdinalWords();
            //HumanizeWordsToPlural();
            //HumanizeWordsToSingular();
            //HumanizeCase();
            DehumizeSentences();
        }

        public static void HumanizeDateTime() {
            Console.WriteLine("Not Humanized");
            Console.WriteLine(DateTime.UtcNow.AddHours(30));
            Console.WriteLine("\nHumanized");
            Console.WriteLine(DateTime.UtcNow.AddHours(30).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(-30).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(30).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(2).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(565).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(-565).Humanize());
        }

        public static void HumanizeSummary() {
            Console.WriteLine("Humanize summary text");
            Console.WriteLine("Long text to truncate".Truncate(10, "..."));
            Console.WriteLine("Long text to truncate".Truncate(10, "..."));
        }

        public static void HumanizeNumbersToWords() {
            Console.WriteLine("Humanize numbers to words");
            Console.WriteLine(1.ToWords());
            Console.WriteLine(2.ToWords());
            Console.WriteLine(3.ToWords());
        }

        public static void HumanizeNumbersToOrdinalWords() {
            Console.WriteLine("Humanize to numbers to ordinal");
            Console.WriteLine(1.ToOrdinalWords());
            Console.WriteLine(2.ToOrdinalWords());
            Console.WriteLine(3.ToOrdinalWords());
        }

        public static void HumanizeWordsToPlural() {
            Console.WriteLine("Humanize words to plural");
            Console.WriteLine("Man".Pluralize());
            Console.WriteLine("Wife".Pluralize());
            Console.WriteLine("Woman".Pluralize());
        }

        public static void HumanizeWordsToSingular() {
            Console.WriteLine("Humanize words to singular");
            Console.WriteLine("Men".Singularize());
            Console.WriteLine("Wives".Singularize());
            Console.WriteLine("Horses".Singularize());
        }        

        public static void HumanizeCase() {
            Console.WriteLine("Humanize Case");
            Console.WriteLine("Humanize Case".Transform(To.LowerCase));
            Console.WriteLine("Humanize Case".Transform(To.UpperCase));
            Console.WriteLine("Humanize Case".Transform(To.TitleCase));
            Console.WriteLine("Humanize Case".Transform(To.SentenceCase));
        }

        public static void DehumizeSentences() {
            Console.WriteLine("Deumanize Sentences");
            Console.WriteLine("Senior Delgotto was a cat".Dehumanize());
            Console.WriteLine("Senior Delgotto was a cat".Kebaberize());
        }

    }
}
