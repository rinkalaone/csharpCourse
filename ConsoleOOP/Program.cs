namespace ConsoleOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            var t4 = new Fahrzeug("Merlin", 140, 10000);
            string infosFahrzeug = t4.Info();
            Console.WriteLine(infosFahrzeug);
            //t4.StarteMotor();
            //t4.Beschleunige(100);
            //Console.WriteLine(t4.Info());
            //var stop = Console.ReadLine();

            var peugeot205 = new PKW("Peugeot 205", 160, 17000, 5);
            Console.WriteLine(peugeot205.Info());

            var Paquebot = new Schiff("MS PAqui", 20, 1500000, 1000, null);
            Console.WriteLine(Paquebot.Info());

            //Paquebot.Belade()
            //Paquebot
        }
    }
}