using System;

namespace Matriz_refatorando
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dimensaoMatriz = Console.ReadLine().Split(' ');
            int linha = int.Parse(dimensaoMatriz[0]);
            int coluna = int.Parse(dimensaoMatriz[1]);
            int[,] matriz = new int[linha, coluna];

            for (int i = 0; i < linha; i++){
                string[] numeros = Console.ReadLine().Split(' ');
                for (int j = 0; j < coluna; j++){
                    matriz[i, j] = int.Parse(numeros[j]);
                }
            }

            Console.WriteLine();
            
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
