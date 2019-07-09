using System;
					
public class Program
{
	  static void printArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine("");
	  }

      
        static void selectSort(int[] arr)
        {	
			
			
           
            for (int j = 0; j < arr.Length-1; j++)
            {
				int minIn = j;
                for (int i = j+1; i < arr.Length; i++)
                {
                    if (arr[i] < arr[minIn])
                    {
                       minIn = i;
                    }
    				            
				}
				
				int temp = arr[minIn];
                arr[minIn] = arr[j];
				arr[j] = temp;
				
            }
           
			printArr(arr);
			
			}


        public static void Main(string[] args)
        {
            int[] arr = { 7, 2, 3, 1, 5, 9 };

            selectSort(arr);
        }
}
