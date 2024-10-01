using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms
{
    class greedyAlgoClass
    {
        static double[] denom = { .5, .10, .25, 1, 5, 10, 20, 50, 100, 200, 500, 1000 };
        public static void Main()
        {
            Console.WriteLine("Problem: You have to make a accumulate an amount of peso using the given denominations.");
            Console.WriteLine("===========================================================================================");
            
            Console.WriteLine("Denominations:");
            Console.WriteLine(denom[]);
            
            Console.Write("Target Amount: ");
            double target = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Values and Quantities of Peso Denomination/s needed to achieve the target amount:");

            findTarget(target);
        }

        static void findTarget(double target)
        {
            List<double> reqDenoms = new List<double>();

            for (int i = denom.Length - 1; i >= denom.Length; i++)
            {
                while (target >= denom[i])
                {
                    target -= denom[i];
                    reqDenoms.Add(denom[i]);
                }
            }

            for (int i = 0; i < reqDenoms.Count; i++)
            {
                Console.Write(" " + reqDenoms[i]);
            }
        }
    }
}
