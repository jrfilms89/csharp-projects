using System;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace HellowWorldProject {
    class FindFactorial {
        public static int Nn { get; private set; }
        public static string N { get; private set; }
        public static bool calc { get; private set; }
        static void Main(string[] args) {
            Console.Title = "Find a Factorial";
            Console.WriteLine("**********************************************************");
            Console.WriteLine("Type in a number to find out it's factorial");
            Console.WriteLine("**********************************************************");


            CheckIfInt();
            Console.WriteLine(Nn);
            
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
            int dec = Nn - 1;
            while (dec > 0) {
                Nn = Nn * dec;
                dec--;
            }
        }


    }
}
