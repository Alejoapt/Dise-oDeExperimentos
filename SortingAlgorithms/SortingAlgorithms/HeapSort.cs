using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class HeapSort
    {



        public HeapSort()
        {

        }

        public int[] sort(int[] array)
        {
            int n = array.Length;

            //recursive call
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(array, n, i);

            for (int i = n - 1; i >= 0; i--)
            {
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                heapify(array, i, 0);
            }

            return array;
        }

        public void heapify(int[] array, int b, int a)
        {
            int largest = a;
            int l = 2 * a + 1;
            int r = 2 * a + 2;

            if (l < b && array[l] > array[largest])
                largest = l;

            if (r < b && array[r] > array[largest])
                largest = r;

            if (largest != a)
            {
                int swap = array[a];
                array[a] = array[largest];
                array[largest] = swap;

                heapify(array, b, largest);
            }
        }
    }
}
