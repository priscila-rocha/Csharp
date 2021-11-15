
using System;
using System.Globalization;

namespace Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            CadFuncionariocs firstFunc, secondFunc;
            firstFunc = new CadFuncionariocs();
            secondFunc = new CadFuncionariocs();

            Console.Write("Digite o nome do primeiro funcionario: ");
            firstFunc.Nome = Console.ReadLine();
            Console.Write("Digite o salario do primeiro funcionario: ");
            firstFunc.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.Write("Digite o nome do segundo funcionario: ");
            secondFunc.Nome = Console.ReadLine();
            Console.Write("Digite o salario do primeiro funcionario: ");
            secondFunc.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario = (firstFunc.Salario + secondFunc.Salario) / 2.0;

            Console.WriteLine();
            Console.WriteLine($"A média salarial é de {mediaSalario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}