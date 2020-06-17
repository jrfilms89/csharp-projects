using System;
using System.IO.Pipes;

namespace cSharpTypes {
    class Program {
        public static int intIn { get; set; }
        public static int intIn2 { get; set; }
        public static int op { get; set; }
        public static int ans { get; set; }

        static void Main(string[] args) {
            Console.Title = "Calculator";
            Console.WriteLine("Enter a number : ");
            var input = Console.ReadLine();
            var intIn = Convert.ToInt32(input);
            Console.WriteLine(intIn);

            Console.WriteLine("Enter a second number : ");
            var input2 = Console.ReadLine();
            var intIn2 = Convert.ToInt32(input2);

            //Console.Write("Enter an operator : ");
            //var op = Console.ReadLine();

            var ans = intIn + intIn2;
            Console.Write($"{intIn} plus {intIn2} equals {ans}");
            //Calc();
        }
        static void Calc() {
            Console.Write($"{intIn} plus {intIn2} equals {ans}");
        }
    }
}
