using System;

namespace Entrada_de_Dados___Parte_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string frase = Console.ReadLine();
            string firstColor = Console.ReadLine();
            string secondColor = Console.ReadLine();
            string thirdColor = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(frase);
            Console.WriteLine(firstColor);
            Console.WriteLine(secondColor);
            Console.WriteLine(thirdColor);
            Console.WriteLine();

            //string groupColor = Console.ReadLine();
            //string[] colors = groupColor.Split(' ');
            // Outra forma com menos código:

            string[] colors = Console.ReadLine().Split(' ');
            string aColor = colors[0];
            string bColor = colors[1];
            string cColor = colors[2];

            Console.WriteLine();
            Console.WriteLine(aColor);
            Console.WriteLine(bColor);
            Console.WriteLine(cColor);
        }
    }
}
