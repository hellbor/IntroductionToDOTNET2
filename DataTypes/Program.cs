﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
		static readonly string delimiter = "\n-----------------------------------------\n";
		static void Main(string[] args)
		{
			Console.WriteLine("Hello DataTypes");
			#region Bool
			/*Console.WriteLine(sizeof(bool));
			Console.WriteLine(true);
			Console.WriteLine(false);
			Console.WriteLine(Boolean.FalseString);*/
			#endregion

			/*Console.WriteLine(sizeof(char));	//Unicode
			Console.WriteLine('+'.GetType());*/

			Console.WriteLine("Byte");
			Console.WriteLine(sizeof(byte));
			Console.WriteLine(byte.MinValue);
			Console.WriteLine(byte.MaxValue);
			Console.WriteLine(delimiter);

			Console.WriteLine("Sbyte:");
			Console.WriteLine(sizeof(sbyte));
			Console.WriteLine(sbyte.MinValue);
			Console.WriteLine(sbyte.MaxValue);
			Console.WriteLine(delimiter);

			Console.WriteLine("Decimal");
			Console.WriteLine(sizeof(decimal));
			Console.WriteLine(decimal.MinValue);
			Console.WriteLine(decimal.MaxValue);

			//Console.WriteLine(5ul.GetType());

			int a = 2000000000;
			int b = 4;
			try
			{
				Console.WriteLine((a * b).GetType());
			}
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Вот и сказочке конец");
        }
	}
}
