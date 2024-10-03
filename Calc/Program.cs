using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите арифметическое выражение: ");
			string expression = Console.ReadLine();
			expression = expression.Replace('.', ',');	//Метод Replace() заменяет первый указанный символ вторым,
			//(или первую указанную строку второй) и возвращает измененную строку
			//при этом исходная строка остается неизменной!!!
			//Console.WriteLine(exprassion);
			char[] delimiters = new char[] { '+', '-', '*', '/' };
			string[] numbers = expression.Split(delimiters);
			try
			{
				double a = Convert.ToDouble(numbers[0]);
				double b = Convert.ToDouble(numbers[1]);
				#region IFcalc
				//if (expression.Contains('+')) Console.WriteLine($"{a} + {b} = {a + b}");
				//else if (expression.Contains('-')) Console.WriteLine($"{a} - {b} = {a - b}");
				//else if (expression.Contains('*')) Console.WriteLine($"{a} * {b} = {a * b}");
				//else if (expression.Contains('/')) Console.WriteLine($"{a} / {b} = {a / b}");
				#endregion

				switch (expression[expression.IndexOfAny(delimiters)])
				{
					//case '+': Console.WriteLine($"{a} + {b} = {a + b}"); break;
					//case '-': Console.WriteLine($"{a} - {b} = {a - b}"); break;
					//case '*': Console.WriteLine($"{a} * {b} = {a * b}"); break;
					//case '/': Console.WriteLine($"{a} / {b} = {a / b}"); break;
					//default: Console.WriteLine("Error: No operation"); break;   //Не работает

					case '+': Console.WriteLine($"{numbers[0]} + {numbers[1]} = {a + b}"); break;
					case '-': Console.WriteLine($"{numbers[0]} - {numbers[1]} = {a - b}"); break;
					case '*': Console.WriteLine($"{numbers[0]} * {numbers[1]} = {a * b}"); break;
					case '/': Console.WriteLine($"{numbers[0]} / {numbers[1]} = {a / b}"); break;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Main(args);
		}
	}
}
