using System;
using System.Globalization;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

           Console.WriteLine("Digite a Largura e Altura do Retangulo: ");
           retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

          Console.WriteLine($"AREA = {retangulo.Area().ToString("F2", CultureInfo.InvariantCulture)})");


        }
    }
}