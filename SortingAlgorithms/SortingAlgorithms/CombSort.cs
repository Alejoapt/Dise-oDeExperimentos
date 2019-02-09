using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class CombSort
    {
        // Gap (factor de encogimiento)
        public int gap { get; set; }

        public CombSort()
        {

        }

        public int[] sort(int[] array)
        {

            // size of the array 
            int n = array.Length;
            // The gap is initializes with the size of the array
            int gap = n;

            //Verifies if...
            bool swapped = true;

            while (gap != 1 || swapped == true)
            {
                gap = getNextGap(gap);

                swapped = false;

                for (int i = 0; i < n - gap; i++)
                {
                    if (array[i] > array[i + gap])
                    {
                        int temp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = temp;

                        swapped = true;
                    }
                }
            }
            return array;
        }


        public int getNextGap(int gap)
        {
            //Actualizar el valor del gap para la siguiente búsqueda
            gap = (gap * 10) / 13;
            if (gap < 1)
                return 1;
            return gap;
        }
    }
}
