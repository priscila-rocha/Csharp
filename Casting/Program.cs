using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = 5;
            y = 2 * x;

            Console.WriteLine($"Esse numero é inteiro {x}.");
            Console.WriteLine($"Esse numero é inteiro {y}.");

            int p;
            double q;
            p = 5;
            q = 2 * 5;

            Console.WriteLine();
            Console.WriteLine($"Esse numero é inteiro: {p}.");
            Console.WriteLine($"Esse numero é double: {q}.");

            double b = 6.0;
            double B = 8.0;
            double h = 5.0;
            double area = (b + B) / 2 * h;

            Console.WriteLine();
            Console.WriteLine($"A area é do trapézio é: {area}.");


            //Fazendo casting
            int c = 5;
            int d = 2;
            double resultado = (double) c / d;

            Console.WriteLine();
            Console.WriteLine($"O resultado não inteiro da divisão de dois inteiros é: {resultado}.");

            double e = 5.0;
            int f = (int) e;

            Console.WriteLine();
            Console.WriteLine($"Convertendo uma variável double para int: {f}.");
        }
    }
}
