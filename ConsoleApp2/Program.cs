namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputKey = Console.ReadKey(true);
            Console.WriteLine($"Du hast {inputKey} angegeben");

            var path1 = @"C:\ordner\dings\zeug";

            var fstring = $"a string with {path1}";

        }
    }
}