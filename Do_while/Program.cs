using System;
using System.Globalization;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            char repetir;
            do
            {
                Console.WriteLine("Digite a temperatura em Celsius: ");
                double tempCelsius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double tempFahrenheit = 9.0 * tempCelsius / 5.0 + 32;
                Console.WriteLine($"Equivalente em Fahrenheit: {tempFahrenheit.ToString("F1", CultureInfo.InvariantCulture)}");

                Console.WriteLine("Deseja repetir (s/n)?");
                repetir = char.Parse(Console.ReadLine());

            } while (repetir == 's');

        }
    }
}
