using System;
					
public class Program
{
	
	
	
	public static void searchT(int[] arr, int key){
		int test = 0;
		int comp = 0;
		for (int i=0; i<arr.Length; i=i+3){
		comp++;
			if (arr[i]==key){
				Console.WriteLine("Index found: " + i);
					Console.WriteLine("Number of comparisions: " + comp);
				test++;
			}
			else if(arr[i]>key){
				
					for(int k=i; k>key;k--){
						comp++;
						if(key==k){
				Console.WriteLine("Index found: " + k);
							Console.WriteLine("Number of comparisions: " + comp);
							test++;
						}
			}
		}
		
			
		
	}
		if(test==0){
		Console.WriteLine("Index not found");
		}
					}
	
	
	public static void Main()
	{
		
		int []  arr = new int[100];
		for(int i =1; i<100; i++){
			arr[i] = i;
		}
			
		int key = 27;
		
		searchT(arr, key);
	}
}
