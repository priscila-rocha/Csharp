using System;
using System.Globalization;

namespace Circunferencia
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine($"Circunferência: {circunferencia.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double Volume(double raio){
            return 4.0 / 3.0 * Pi * raio * raio * raio;
        }
    }
}
