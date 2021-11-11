using System;
using System.Globalization;

namespace Entrada_de_Dados___Parte_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string nome = Console.ReadLine();
            int idade = int.Parse(Console.ReadLine());
            char sexo = char.Parse(Console.ReadLine());
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(sexo);
            Console.WriteLine(altura);
            
                       
            string[] dados = Console.ReadLine().Split(' ');
            string nomeConsole = dados[0].ToUpper();
            int idadeConsole = int.Parse(dados[1]);
            char sexoConsole = char.Parse(dados[2]);
            double alturaConsole = double.Parse(dados[3], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(nomeConsole);
            Console.WriteLine(idadeConsole);
            Console.WriteLine(sexoConsole);
            Console.WriteLine(alturaConsole.ToString("F2", CultureInfo.InvariantCulture));
            

        }
    }
}
