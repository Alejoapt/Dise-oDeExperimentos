using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class ArrayGenerator
    {

        public ArrayGenerator()
        {

        }

        public int[] generateRandomArray(int n)
        {

            Random r = new Random();
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1, 10000);
            }

            return array;
        }

        public int[] generateOrderedArray(int n)
        {
            int[] array = generateRandomArray(n);
            Array.Sort(array);
            return array;
        }

        public int[] generateInverseOrderedArray(int n)
        {
            int[] array = generateRandomArray(n);
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }
    }
}
