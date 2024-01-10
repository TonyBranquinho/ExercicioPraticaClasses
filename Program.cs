using ExercicioPatricaClasses;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            Pessoas primeiraPessoa, segundaPessoa;

            primeiraPessoa = new Pessoas();
            segundaPessoa = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            primeiraPessoa.nome = Console.ReadLine();
            Console.Write("Idade: ");
            primeiraPessoa.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine("Nome: ");
            segundaPessoa.nome = Console.ReadLine();
            Console.Write("Idade: ");
            segundaPessoa.idade = int.Parse(Console.ReadLine());

            string maisVelha = "x";
            if (primeiraPessoa.idade > segundaPessoa.idade) {
                maisVelha = primeiraPessoa.nome;
            }
            else {
                maisVelha = segundaPessoa.nome;
            }

            Console.WriteLine("Pessoa mais velha: " + maisVelha);
        }
    }
}