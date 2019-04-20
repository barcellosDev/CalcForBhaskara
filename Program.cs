using System;
using System.Globalization;

namespace CsharpCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;           
            Console.Write("Informe o valor de a: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o valor de b: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o valor de c: ");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (a > 0)
            {
                delta = Math.Pow(b, 2.0) - 4 * a * c;
                if (delta >= 0)
                {
                    x1 = (double) (-b + Math.Sqrt(delta)) / (2.0 * a);
                    x2 = (double) (-b - Math.Sqrt(delta)) / (2.0 * a);
                    Console.WriteLine("x1 = " + x1.ToString("F1", CultureInfo.InvariantCulture));
                    Console.Write("x2 = " + x2.ToString("F1", CultureInfo.InvariantCulture));
                } else
                {
                    Console.Write("IMPOSSÍVEL CALCULAR!");
                }
            } else
            {
                Console.Write("IMPOSSÍVEL CALCULAR!");
            }
        }
    }
}
