using System;

namespace Pessoa//nome do projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaClasse p1, p2; //coloca apenas a pessoa e não cada atributo

            p1 = new PessoaClasse(); //instancia o pessoa
            p2 = new PessoaClasse(); //instancia o pessoa


            Console.WriteLine("Digite o nome da primeira pessoa");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da segunda pessoa");
            p2.Idade = int.Parse(Console.ReadLine());

            if(p1.Idade > p2.Idade){
                Console.WriteLine($"A pessoa mais velha é {p1.Nome}, tendo {p1.Idade} anos.");
            } else{
                Console.WriteLine($"A pessoa mais velha é {p2.Nome}, tendo {p2.Idade} anos.");
            }


            Console.WriteLine($"O nome da primeira pessoa é {p1.Nome} e sua idade é {p1.Idade}");
            Console.WriteLine($"O nome da segunda pessoa é {p2.Nome} e sua idade é {p2.Idade}");
        }
    }
}
