using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Bubble_Sort_Abdurrahman_YORULMAZ");
			int elements;
			Console.WriteLine("Write how many elements you want to enter the array:");
			elements = Convert.ToInt32(Console.ReadLine());
			int[] array = new int[elements];
			Console.WriteLine("\nEnter " + elements + " numbers.\n");
			for (int counter = 0; counter < elements; counter++)
			{
				Console.WriteLine("Enter the element to be kept in the " + counter + ". Index");
				array[counter] = Convert.ToInt32(Console.ReadLine());
			}
			Console.Write("\n\nThe first version of the series: ");
			foreach (int value in array)
			{
				Console.Write(value + " ");
			}
			Console.WriteLine();
			sort(array);
			write(array);
		}
		public static void write(int[] array)
		{
			Console.Write("The series in ascending order: ");
			foreach (int value in array)
			{
				Console.Write(value + " ");
			}
			Console.WriteLine("\n\n>>Press any key to exit.");
			Console.ReadKey();
		}
		public static void sort(int[] array)
		{
			int i = 1, j, holder;
			int arrayx = array.Length;
			while (i < arrayx)
			{
				j = arrayx - 1;
				while (j >= 1)
				{
					if (array[j - 1] > array[j])
					{
						holder = array[j];
						array[j] = array[j - 1];
						array[j - 1] = holder;
					}
					j--;
				}
				i++;
			}
		}
	}
	}