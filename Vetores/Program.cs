using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanhoVetor = int.Parse(Console.ReadLine());
            double[] numeros = new double[tamanhoVetor];

            for (int i = 0; i < tamanhoVetor; i++){
                numeros[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine();

            foreach(double n in numeros)//tipo de n é o mesmo tipo do vetor
            {
                //na impressão chama a variavel n, pois ela representa o elemento dentro do vetor
                Console.WriteLine(n.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
