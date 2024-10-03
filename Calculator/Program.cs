using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*Console.Write("Введите выражение: ");
			double a = Convert.ToDouble(Console.ReadLine());
			double b = Convert.ToDouble(Console.ReadLine());
			double result = Convert.ToDouble(Console.ReadLine());
			char sign = Convert.ToChar(Console.ReadLine());*/

			double a, b, result;
			char sign;
			Console.Write("Введите первое число: ");
			a = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите знак действия: ");
			sign = Convert.ToChar(Console.ReadLine());
			Console.Write("Введите второе число: ");
			b = Convert.ToDouble(Console.ReadLine());

			if (sign == '+')
			{
				result = a + b;
				Console.WriteLine(result);
				Console.WriteLine();
			}
			if (sign == '-')
			{
				result = a - b;
				Console.WriteLine(result);
				Console.WriteLine();
			}
			if (sign == '*')
			{
				result = a * b;
				Console.WriteLine(result);
				Console.WriteLine();
			}
			if (sign == '/')
			{
				result = a / b;
				Console.WriteLine(result);
				Console.WriteLine();
				if (b == 0)
				{
					Console.WriteLine("ERROR!");
					Console.WriteLine();
				}
			}
		}
	}
}
