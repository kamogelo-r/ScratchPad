using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 11, 12, 3 };
            var b = new int[] { 2, 4, 6 };
            
            Console.WriteLine("----");

            var array = new double[] { 2, 3, 4 };
            int i = 0, k = 1, total = 0, product = 0;

            Number(i);
            Console.WriteLine(i); //value : i does not change (different memory location)

            NumberRef(ref k);
            Console.WriteLine(k); //ref : k changes to what is in the method (same memory location)

            Calculate(1, 1, out total, out product);
            Console.WriteLine("Sum = {0} && Product = {1}", total, product); //out : more than one value

            int[] numbers = { 1, 2, 3, 4, 5 };

            ParamsMethod(); //params : makes parameters optional
            ParamsMethod(numbers);
            ParamsMethod(2, 4, 6); //can insert as many params (arguments) as possible

            Console.Read();
        }

        public static void Calculate(int x, int y, out int sum, out int product)
        {
            sum = x + y;
            product = x * y;
        }

        public static void Number(int j)
        {
            j = 5;
        }

        public static void NumberRef(ref int j)
        {
            j = 5;
        }

        public static void ParamsMethod(params int[] numbers) //params comes last; after all params. Only 1 params keyword allowed in method
        {
            Console.WriteLine("Number of elements in array: {0}", numbers.Length);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(i);
            }
        }

        public string Rps(string p1, string p2)
        {
            Dictionary<string, string> rps = new Dictionary<string, string>();

            rps["rock"] = "rock";
            rps["paper"] = "paper";
            rps["scissors"] = "scissors";
            rps["rock"] = "paper";
            rps["rock"] = "scissors";
            rps["paper"] = "scissors";

            string value;
            rps.TryGetValue("rock", out value);
            string value1;
            rps.TryGetValue("paper", out value1);
            string value2;
            rps.TryGetValue("scissor", out value2);

            foreach (var item in rps)
            {

            }

            return "";
        }

        public static string Bmi(double weight, double height)
        {
            double bmi1 = (weight / height);
            double bmi = Math.Pow(bmi1, 2);
            string weighting = "";

            if (bmi <= 18.5)
            { weighting = "Underweight"; }
            else if (bmi <= 25.0)
            { weighting = "Normal"; }
            else if (bmi <= 30.0)
            { weighting = "Overweight"; }
            else if (bmi > 30)
            { weighting = "Obese"; }

            return weighting;
        }
    }
}
