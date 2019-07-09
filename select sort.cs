using System;

namespace selectSort
{
    class Program
    {
        static void printArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine("");
        }

        static void writeInfo(string unsort, int[] array)
        {
            Console.Write(unsort + " array: ");
            printArr(array); ;
            Console.WriteLine("");
        }

        static int[] shiftArr(int[] arr, int smNumb, int indx)
        {

          for(int i = indx; i>0; i--)
            {
                int temp = 0;
                temp = arr[indx - 1];
                arr[indx] = temp;
            }

            return arr;
        }

        static void selectSort(int[] arr)
        {
            int smNumb = arr[0];
            int indx = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (smNumb > arr[i])
                    {
                        smNumb = arr[i];
                        indx = i;
                    }

                }
                //Console.WriteLine("" + indx + smNumb);
                //arr[0] = smNumb;
                arr = shiftArr(arr, smNumb, indx);
                printArr(arr);
            }
           
        }


        static void Main(string[] args)
        {
            int[] arr = { 7, 2, 3, 1 };

            selectSort(arr);
        }
    }
}
