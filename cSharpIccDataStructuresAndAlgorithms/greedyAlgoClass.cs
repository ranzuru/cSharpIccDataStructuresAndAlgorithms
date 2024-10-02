using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms
{
    class greedyAlgoClass
    {
        static double[] denom = { 0.05, 0.10, 0.25, 1, 5, 10, 20, 50, 100, 200, 500, 1000 };
        public static void Main()
        {
            Console.WriteLine("Peso Dispensing System");
            Console.WriteLine("===========================================================================================");
            
            Console.WriteLine("Denominations:");
            Console.WriteLine("[ " + string.Join(", ", denom) + " ]");
            Console.WriteLine("\nNote: If target amount has a .01/ .02/ .03/ .04 remainder, it will be converted into Bobot.");

            Console.Write("\nAmount: ");
            double target = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\nDispensed Peso/s:");
            Console.WriteLine("------------------------------------------------------------------------------------------");
            findTarget(target);
            Console.WriteLine("");
        }

        static void findTarget(double target)
        {
            List<double> reqDenoms = new List<double>();

            target = Math.Round(target, 2);

            for (int i = denom.Length - 1; i >= 0; i--)
            {
                while (target >= denom[i])
                {
                    target -= denom[i];
                    reqDenoms.Add(denom[i]);
                    target = Math.Round(target, 2);
                }
            }

            for (int i = 0; i < reqDenoms.Count; i++)
            {
                if (i == reqDenoms.Count - 1) Console.Write(reqDenoms[i]);
                else Console.Write(reqDenoms[i] + ", ");
            }
            
            if (target == .04 || target == .03 || target == .02 || target == .01) Console.WriteLine("\nwith BOBOT");
        }
    }
}
