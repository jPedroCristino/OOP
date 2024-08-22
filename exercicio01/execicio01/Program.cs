using execicio01;
using System;
using System.Globalization;
using System.Xml;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa A = new Pessoa();
            Pessoa B = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine("Nome: ");
            A.nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            A.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa");
            Console.WriteLine("Nome:");
            B.nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            B.idade = int.Parse(Console.ReadLine());

            if (A.idade > B.idade && A.idade > 0)
            {
                Console.WriteLine("Pessoa mais velha:" + A.nome);
            }
            else if (B.idade > A.idade && B.idade > 0) 
            {
                Console.WriteLine("Pessoa mais velha: " + B.nome);
            }
            else if (A.idade <= 0 || B.idade <= 0)
            { Console.WriteLine("Idade inválida"); }
        }
    }
}
