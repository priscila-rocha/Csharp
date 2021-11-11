using System;

namespace while_soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());
            int soma = 0;

            while (entrada != 0)
            {
                soma += entrada;
                entrada = int.Parse(Console.ReadLine());                
            }
            Console.WriteLine($"A soma de todos os numeros é {soma}");
        }

    }
}
