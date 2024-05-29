namespace Aufgabe1Variablen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input Variables
            int entfernungInMetern;
            int stunden;
            int minuten; 
            int sekunden;

            // Output Variables
            double meterProSekunden;
            double kilometerProStunde;
            double meilenProStunde;

            Console.Write("Entfernung (in Meter): ");
            entfernungInMetern = int.Parse(Console.ReadLine());
            Console.Write("Stunden: ");
            stunden = int.Parse(Console.ReadLine());
            Console.Write("Minuten: ");
            minuten = int.Parse(Console.ReadLine());
            Console.Write("Sekunden: ");
            sekunden = int.Parse(Console.ReadLine());

            // Compute metrics
            int zeitInSekunden = (stunden * 3600) + (minuten * 60) + sekunden;
            meterProSekunden = (double)entfernungInMetern / zeitInSekunden;
            kilometerProStunde = meterProSekunden * 3.6;
            meilenProStunde = kilometerProStunde / 1.609;

            // Ausgaben
            Console.WriteLine($"Meter/Sekunde: \t{Math.Round(meterProSekunden, 2)}");
            Console.WriteLine($"Kilometer/Stunde: \t{Math.Round(kilometerProStunde, 2)}");
            Console.WriteLine($"Meilen/Stunde: \t{Math.Round(meilenProStunde, 2)}");
        }
    }
}