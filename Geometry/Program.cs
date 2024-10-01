#define SQUARE
#define TRIANGLE_1
#define TRIANGLE_2
#define TRIANGLE_3
#define TRIANGLE_4
#define ROMBUS
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
			int n = Convert.ToInt32(Console.ReadLine());

#if SQUARE
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n - 1; j++) Console.Write("* ");
				Console.WriteLine("* ");
			}
			Console.WriteLine();
#endif

#if TRIANGLE_1
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j <= i; j++) Console.Write("* ");
				Console.WriteLine(" ");
			}
			Console.WriteLine();
#endif
#if TRIANGLE_2
			for (int i = n; i >= 1; i--)
			{
				for (int j = 0; j < i; j++) Console.Write("* ");
				Console.WriteLine(" ");
			}
			Console.WriteLine();
#endif
#if TRIANGLE_3
			for (int i = n; i >= 1; i--)
			{
				for (int j = n; j > i; j--) Console.Write("  ");
				for (int k = 0; k < i; k++) Console.Write("* ");
				Console.WriteLine();
			}
			Console.WriteLine();
#endif
#if TRIANGLE_4
			for (int i = 1; i <= n; i++)
			{
				for (int j = n; j > i; j--) Console.Write("  ");
				for (int k = 0; k < i; k++) Console.Write("* ");
				Console.WriteLine();
			}
			Console.WriteLine();
#endif
#if ROMBUS
			for (int i = 0; i < n; i++)
			{
				for (int j = i; j < n; j++)
					Console.Write(" ");
					Console.Write("/");

				for (int j = 0; j < i; j++)
					Console.Write("  ");
					Console.Write("\\");
					Console.WriteLine();
			}
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j <= i; j++)
					Console.Write(" ");
					Console.Write("\\");

				for (int j = i; j < n - 1; j++)
					Console.Write("  ");
					Console.Write("/");
					Console.WriteLine();
			}
            Console.WriteLine();
#endif
#if CHESS
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write(i % 2 == j % 2 ? "+ " : "- ");
					/*if ((i + j) % 2 == 0) Console.Write("+ ");
					else Console.Write("- ");*/
				}
				Console.WriteLine();
			} 
#endif
        }
	}
}
