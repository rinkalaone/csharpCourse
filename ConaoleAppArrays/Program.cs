namespace ConaoleAppArrays
{
    internal class Program
    {
        enum myWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
        }

        static void Main(string[] args)
        {
            #region Arrays
            Console.WriteLine("Hello, World!");


            var arrayOfNumbers = new[] { 1, 2, 3 };
            Console.WriteLine("Laenge: " + arrayOfNumbers.Length);

            var sumarr = arrayOfNumbers.Sum();

            var aver = arrayOfNumbers.Average();


            var listOfnumbers = new List<int>();
            listOfNumbers.Add(1);
            listOfnumbers.Remove(1);
            Console.WriteLine("Laenge: " + listOfnumbers.Count());
            #endregion

            #region Bedingungen

            int num1 = 3, num2 = 4;

            if (num1 == num2) 
            { Console.WriteLine("beide sind gleich"); }

            if (num1 >0 ^ num2>0) { Console.WriteLine("Eins von beiden ist positiv, aber nur eins"); }

            #endregion

            foreach (var item in listOfnumbers)
            {
                Console.WriteLine("item");
            }

         
        }

    }
     
}