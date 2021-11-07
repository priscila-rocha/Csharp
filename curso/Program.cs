using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;
            int idade = 37;
            string nome = "Priscila";
            char sexo = 'F';
            string sexoExtenso = String.Empty;

            if (sexo == 'F')
            {
                sexoExtenso = "feminino";
            }
            else
            {
                sexoExtenso = "masculino";
            }

            Console.WriteLine("Hello World");
            Console.Write("Bom dia! ");
            Console.Write("Até mais!");

            Console.WriteLine();
            Console.WriteLine($"\nO resultado sem configuração de número de casas decimais é: {x}.");
            Console.WriteLine($"O resultado com configuração de duas casas decimais é: {x.ToString("F2")}.");
            Console.WriteLine($"O resultado com configuração de quatro casas decimais é: {x.ToString("F4")}.");
            Console.WriteLine($"O resultado com configuração regional é: {x.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine();
            Console.WriteLine($"A paciente {nome}, tem {idade} anos e seu sexo é {sexoExtenso}.");

        }
    }
}
