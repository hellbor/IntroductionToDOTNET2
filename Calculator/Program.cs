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
			Console.Write("Введите выражение:" );
			double a = Convert.ToDouble(Console.ReadLine());
			double b = Convert.ToDouble(Console.ReadLine());
			char s = Convert.ToChar(Console.ReadLine());

			if(s=='+')
			{
                Console.WriteLine($"{a}+{b}={a+b}");
            }
		}
	}
}
