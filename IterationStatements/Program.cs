namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        //Write a method to check whether a given number is even or odd

        //Write a method to check whether a given number is positive or negative

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            // LukeWarm Section - Getting the feet wet : 

            PrintingPress.PosToNegative1000Printer();
            PrintingPress.ThreeToNineNineNinePrinter();
            Console.WriteLine("Enter the first Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The larger number is: ");
            Console.WriteLine(NumberChecker.TakeTwoNums(num1, num2));
            Console.WriteLine("Enter a number: ");
            var num3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The number {num3} " + NumberChecker.IsEvenOrOdd(num3));
            Console.WriteLine("Enter a number: ");
            var num4 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The number {num4} " + NumberChecker.IsPositive(num4));
            Console.WriteLine("How Old are you?");
            var num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"This person is currently {NumberChecker.IsOldEnough(num5)}.");

            // Heating Up Section :

            int num6 = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberChecker.isBetweenN10P10(num6));

            Console.WriteLine("Please input a number from 3 to 12. \n" +
                "This will print the multiplication table for that number.");
            int tableNumber = Convert.ToInt32(Console.ReadLine());

            while (tableNumber > 13 || tableNumber < 1)
            {
                Console.WriteLine("Please input a number from 3 to 12.");
                tableNumber = Convert.ToInt32(Console.ReadLine());
            } 

            PrintingPress.TheMultiplicationTable(tableNumber);

            //Will attempt TryParse later.
            //bool check = int.TryParse(num5, out int areThey);
        }
    }
}
