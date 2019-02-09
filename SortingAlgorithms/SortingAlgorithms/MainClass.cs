using System;

namespace SortingAlgorithms
{
    public class MainClass
    {

        
        public MainClass()
        {
            HeapSort heapSort = new HeapSort();
            CombSort CombSort = new CombSort();
            ArrayGenerator arrays = new ArrayGenerator();

            int[] array1 = arrays.generateRandomArray(10);
            int[] array2 = arrays.generateRandomArray(100);
            //int[] array3 = arrays.generateRandomArray(1000);
            //int[] array4 = arrays.generateRandomArray(10000);
           // int[] array5 = arrays.generateRandomArray(100000);
         //   int[] array6 = arrays.generateRandomArray(1000000);


            DateTime time1 = DateTime.Now;
            heapSort.sort(array1);
            DateTime time2 = DateTime.Now;
            TimeSpan total = new TimeSpan(time2.Ticks - time1.Ticks);
            Console.WriteLine(total.TotalMilliseconds + "");

            DateTime time3 = DateTime.Now;
            heapSort.sort(array2);
            DateTime time4 = DateTime.Now;
            TimeSpan total1 = new TimeSpan(time3.Ticks - time4.Ticks);
            Console.WriteLine(total.TotalMilliseconds + "");
            // sw.Write("Inverso MergeSort = " + total.TotalMilliseconds + "\n");
            Console.ReadKey(true);
        }

        static void Main(string[] args)
        {

            MainClass mainClass = new MainClass();
            Console.WriteLine("Hello World!");
        }
    }
}
