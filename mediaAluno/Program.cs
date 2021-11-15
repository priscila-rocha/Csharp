using System;
using System.Globalization;

namespace mediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno;
            aluno = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Digite a nota do primeiro trimestre: ");
            aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a nota do primeiro trimestre: ");
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.Write("Digite a nota do primeiro trimestre: ");
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"NOTA FINAL = {aluno.CaldularNotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
        }
    }
}
