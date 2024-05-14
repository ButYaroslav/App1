using System;
using System.Text;

namespace App1;
class Program
{
	static void Main()
	{
		Console.InputEncoding = Encoding.UTF8;
		Console.OutputEncoding = Encoding.UTF8;

		Console.Write("Введіть значення x: ");
		double x = Convert.ToDouble(Console.ReadLine());

		Console.Write("Введіть значення a: ");
		double a = Convert.ToDouble(Console.ReadLine());

		double result = CalculateFunction(x, a);
		Console.WriteLine($"Результат обчислення функції: {result}");
	}

	static double CalculateFunction(double x, double a)
	{
		double y = Math.Log(x - 4, 2) + Math.Exp(2 * a - x);
		return y;
	}
}
