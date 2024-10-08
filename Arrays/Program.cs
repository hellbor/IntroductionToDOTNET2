#define ARRAYS_1
#define ARRAYS_2
//#define JAGGED_ARRAY

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if ARRAYS_1
			Console.Write("Введите размер массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			//int[] arr = { 3, 5, 8, 13, 21 };
			int[] arr = new int[n];
			Random rand = new Random(0);
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100);
			}
			//for (int i = 0; i < arr.Length; i++)
			//{
			//	Console.Write(arr[i] + "\t");
			//}
			//Console.WriteLine();

			foreach (int i in arr)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine($"Сумма элементов массива: {arr.Sum()}");
			Console.WriteLine();

			Console.WriteLine($"Среднее-арифметическое элементов массива: {arr.Average()}");
			Console.WriteLine();

			Console.WriteLine($"Минимальное значение в массиве: {arr.Min()}");
			Console.WriteLine();

			Console.WriteLine($"Максимальное значение в массиве: {arr.Max()}");
			Console.WriteLine();

			Console.WriteLine("Отсортированный массив: ");
			Array.Sort(arr);
			foreach (int i in arr)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine($"Отсортированный массив в обратном порядке: ");
			for (int i = n - 1; i >= 0; i--)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine();
			Console.WriteLine();
#endif

#if ARRAYS_2
			Console.Write("Введите количество строк: ");
			int rows = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите количество элементов строки: ");
			int cols = Convert.ToInt32(Console.ReadLine());

			int[,] i_arr_2 = new int[rows, cols];

			//Console.WriteLine(i_arr_2.Rank);

			//Random rand = new Random(0);

			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					i_arr_2[i, j] = rand.Next(100);
				}
			}
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i, j] + "\t");
				}
				Console.WriteLine();
			}

			//foreach(int i in i_arr_2)
			//{
			//	Console.Write(i + "\t");
			//}

			int sum2 = i_arr_2.Cast<int>().Sum();
			Console.WriteLine($"Сумма элементов двумерного массива: {sum2}");
			Console.WriteLine();

			/*for(int i = 0; i < rows; i++)
			{
				for(int j = 0; j < cols; j++)
				{
					sum += i_arr_2[i, j];
				}
            Console.WriteLine($"Сумма всех элементов двумерного массива: {sum}");
			Console.ReadKey();break;
			}*/

			double avg2 = i_arr_2.Cast<int>().Average();
			Console.WriteLine($"Среднее-арифметическое двумерного массива: {avg2}");
			Console.WriteLine();

			/*for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					avg += i_arr_2[i, j];
				}
				Console.WriteLine($"Среднее-арифметическое двумерного массива: {avg}");
				Console.ReadKey();break;
			}*/

			int min2 = i_arr_2.Cast <int>().Min();
            Console.WriteLine($"Минимальное значение двумерного массива: {min2}");
			Console.WriteLine();

			int max2 = i_arr_2.Cast<int>().Max();
            Console.WriteLine($"Максимальное значение двумерного массива: {max2}");
			Console.WriteLine();


#endif

#if JAGGED_ARRAY
			//for (int a = 0, b = 1, c = a + b; a < 1000; a = b, b = c, c = a + b) ;
			int[][] arr_jagged = new int[][]
			{
				new int[]{0,1,1,2 },
				new int[]{3,5,8,13,21 },
				new int[]{34,55,89 },
				new int[]{144,233,377,610,987 }
			};
			for (int i = 0; i < arr_jagged.Length; i++)
			{
				for (int j = 0; j < arr_jagged[i].Length; j++)
				{
					Console.Write(arr_jagged[i][j] + "\t");
				}
				Console.WriteLine();
			} 
#endif
		}
	}
}
