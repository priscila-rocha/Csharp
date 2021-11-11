using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] dimensaoMatriz = Console.ReadLine().Split(' ');
            int x = int.Parse(dimensaoMatriz[0]);
            int y = int.Parse(dimensaoMatriz[1]);
            int[,] matriz = new int[x, y];

            string[] firstLine = Console.ReadLine().Split(' ');
            string[] secondLine = Console.ReadLine().Split(' ');

            matriz[0, 0] = int.Parse(firstLine[0]);
            matriz[0, 1] = int.Parse(firstLine[1]);
            matriz[0, 2] = int.Parse(firstLine[2]);
            matriz[1, 0] = int.Parse(secondLine[0]);
            matriz[1, 1] = int.Parse(secondLine[1]);
            matriz[1, 2] = int.Parse(secondLine[2]);

            Console.WriteLine();

            Console.WriteLine($"{matriz[0, 0]} {matriz[0, 1]} {matriz[0, 2]}");
            Console.WriteLine($"{matriz[1, 0]} {matriz[1, 1]} {matriz[1, 2]}");
        }
    }
}
