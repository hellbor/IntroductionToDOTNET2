#define SQUARE
#define TRIANGLE_1
#define TRIANGLE_2
#define TRIANGLE_3
#define TRIANGLE_4
#define CHESS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите размер фигуры: ");
			int size = Convert.ToInt32(Console.ReadLine());

#if SQUARE
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size - 1; j++) Console.Write("* ");
				Console.WriteLine("* ");
			}
			Console.WriteLine();
#endif

#if TRIANGLE_1
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j <= i; j++) Console.Write("* ");
				Console.WriteLine(" ");
			}
			Console.WriteLine();
#endif
#if TRIANGLE_2
			for (int i = size; i >= 1; i--)
			{
				for (int j = 0; j < i; j++) Console.Write("* ");
				Console.WriteLine(" ");
			}
			Console.WriteLine();
#endif
#if TRIANGLE_3
			for (int i = size; i >= 1; i--)
			{
				for (int j = size; j > i; j--) Console.Write("  ");
				for (int k = 0; k < i; k++) Console.Write("* ");
				Console.WriteLine();
			}
			Console.WriteLine();
#endif
#if TRIANGLE_4
			for (int i = 1; i <= size; i++)
			{
				for (int j = size; j > i; j--) Console.Write("  ");
				for (int k = 0; k < i; k++) Console.Write("* ");
				Console.WriteLine();
			}
			Console.WriteLine();
#endif
#if CHESS
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					if ((i + j) % 2 == 0) Console.Write("+ ");
					else Console.Write("- ");
				}
				Console.WriteLine();
			} 
#endif
		}
	}
}
