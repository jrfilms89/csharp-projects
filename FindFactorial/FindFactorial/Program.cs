using System;

namespace FindFactorial {
    class Program {

        public static long Nn { get; private set; }
        public static string N { get; private set; }

        static void Main(string[] args) {
            Console.Title = "Find a Factorial";
            Console.WriteLine("**********************************************************");
            Console.WriteLine("Type in a number to find out it's factorial");
            Console.WriteLine("**********************************************************");

            CheckIfInt();
            Console.WriteLine($"Your Factorial is: {Nn}");
            Console.ReadKey();
        }
        static void CheckIfInt() {
            N = Console.ReadLine();
            while (!Int32.TryParse(N, out _)) {
                Console.WriteLine("Not a valid integer. Please try again.");
                N = Console.ReadLine();
            }
            Nn = Int32.Parse(N);
            FindFactorial();
        }
        static void FindFactorial() {
            long dec = Nn - 1;
            while (dec > 0) {
                Nn = Nn * dec;
                dec--;
            }
        }
    }
}
