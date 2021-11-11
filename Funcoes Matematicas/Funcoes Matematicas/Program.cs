using System;

namespace Funcoes_Matematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;

            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);
            Console.WriteLine($"A raiz quadrada de {x} é {A}.");
            Console.WriteLine($"A raiz quadrada de {y} é {B}.");
            Console.WriteLine($"A raiz quadrade de 25 é {C}.");

            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);
            Console.WriteLine();
            Console.WriteLine($"{x} elevado a {y} é: {A}.");
            Console.WriteLine($"{x} elevado a 2 é {B}.");
            Console.WriteLine($"5 elevado a 2 é: {C}.");

            A = Math.Abs(y);
            B = Math.Abs(z);
            Console.WriteLine();
            Console.WriteLine($"Valor absoluto de {y} é {A}.");
            Console.WriteLine($"Valor absoluto de {z} é {B}.");
        }
    }
}
