using System;

namespace for_soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 0; i < contador; i++){
                int numeros = int.Parse(Console.ReadLine());
                soma += numeros;
            }
            Console.WriteLine(soma);
        }
    }
}
