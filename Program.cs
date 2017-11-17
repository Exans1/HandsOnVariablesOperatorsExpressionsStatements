using System;

namespace HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            int sum = x + y;
            Console.WriteLine("Sum of "+ x +" and "+ y +" is: "+ sum);
            Console.WriteLine("Are the Values of sum and 7 equal? "+ (sum == 7 ? "true" : "false"));

            string text1 = "Hello";
            string text2 = "World";
            string message = text1 + " " + text2;
            Console.WriteLine("Message: " + message);
            Console.WriteLine("Press Enter to continue . . . "); 
            Console.ReadLine();

        }
    }
}
