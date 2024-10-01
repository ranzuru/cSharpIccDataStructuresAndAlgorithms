using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms
{
    class randomNumberGenerator
    {
        public int[] data;
        public static Random generator = new Random();

        public randomNumberGenerator(int size)
        {
            data = new int[size];

            for (int i = 0; i < size; i++)
            {
                data[i] = generator.Next(-99, 99);
            }
        }
    }
}
