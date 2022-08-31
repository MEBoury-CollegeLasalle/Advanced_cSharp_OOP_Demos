using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Example of ternary operator usage
            bool booleanExpression = (1 == 2);
            string retVal = (booleanExpression) ? "TRUE" : "FALSE";
            Console.WriteLine($"The expression evaluates to {retVal}.");
            // result: The expression evaluates to FALSE.;

            PauseConsole();

            // Example of null-coalesce operator
            int? nullIntValue = null;
            int defaultValue = 1;
            int nonNullValue = (nullIntValue ?? defaultValue);
            Console.WriteLine($"Stored non-null value: {nonNullValue}");
            // result: Stored non-null value: 1;

            PauseConsole();

            // Example of lambda function/expression
            List<int> intList = new List<int>(new int[] { 1, 2, 3 }) ;
            intList.ForEach((int integer) => {
                Console.WriteLine($"Number in list: {integer}");
            });
            /*
             * result:
             * Number in list: 1
             * Number in list: 2
             * Number in list: 3
             */


        }

        public static void PauseConsole()
        {
            Console.WriteLine("Press the Enter key to continue...");
            string? whatever = Console.ReadLine();
        }
    }
}