
using System;
using System.Globalization;

namespace Funcionarios
{
    class PorcentagemSalario
    {
        static void Main(string[] args)
        {
            CadFuncionariocs funcionario;
            funcionario = new CadFuncionariocs();

            Console.Write("Digite o nome do funcionario: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Digite o salario do funcionario: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o imposto sobre salario do funcionario: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Funcionário: {funcionario}");

            Console.Write("Digite a porcentagem a ser acrescida no salario do funcionario: ");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario.AumentarSalario(aumento);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {funcionario}");
        }
    }
}