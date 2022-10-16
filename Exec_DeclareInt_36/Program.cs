using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DeclareInt_36
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Q1
			int count = 1 + (2 + 2) * 3 - 1;
			Console.WriteLine("Q1: "+count);

			//Q2
			int number1 = 120 / 7;
			int number2 = 120 % 7;
			Console.WriteLine("Q2: 120的商數是: "+number1);
			Console.WriteLine("Q2: 120的餘數是: "+number2);

			//Q3

			int number3 = 9 % 2;
			int number4 = 202 % 2;

			if(number3>0)
			{
				Console.WriteLine("Q3: 9是質數");
			}
			else
			{
				Console.WriteLine("Q3: 9是偶數");
			}
			if (number4 > 0)
			{
				Console.WriteLine("Q3: 202是質數");
			}
			else
			{
				Console.WriteLine("Q3: 202是偶數");
			}

			//Q4
			int number5 = 20; int number6 = 101;
			int temp = number5;
			number5= number6;
			number6 = temp;
			Console.WriteLine($"Q4: number5={number5},number6={number6}");

		}
	}
}
