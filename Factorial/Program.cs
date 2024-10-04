using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите число для вычисления факториала: ");
			int n = Convert.ToInt32(Console.ReadLine());
			int factorial = 1;
			for (int i = 1; i <= n; i++)
			{
				factorial *= i;
				Console.WriteLine($"{i}! = {factorial}");
			}
        }
	}
}
