using System;

namespace binarcyseach {
 class Program {

  static int bSearch(int[] array, int k) {

   int min = 0;
   int max = array.Length - 1;
   int counter = 0

   while (min <= max) {
    counter++;
    int mid = (min + max) / 2;

    if (k == array[mid]) {

     Console.WriteLine("Index: " + mid++);
     Console.WriteLine("Comparisions done:" + counter)
     return 1;
    } else if (k < array[mid]) {
     max = mid - 1;
    } else {
     min = mid + 1;
    }

   }
   Console.WriteLine("Not found");
   return 0;
  }

  public static void Main(string[] args) {

   int[] arrget = new int[100];
   for (int i = 0; i < 100; i++) {
    arrget[i] = i;
   }

   bSearch(arrget, 5);
  }

 }



 
}
