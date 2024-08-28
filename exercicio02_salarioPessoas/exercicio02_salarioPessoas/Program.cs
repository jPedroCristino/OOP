using System;
using System.Globalization;
using System.Xml;

namespace exercicio02_salarioPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa A = new Pessoa();
            Pessoa B = new Pessoa();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.WriteLine("Nome: "); 
            A.nome = Console.ReadLine();
            Console.WriteLine("Salário: "); 
            A.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.WriteLine("Nome: "); 
            B.nome = Console.ReadLine();
            Console.WriteLine("Salário: "); 
            B.salario = double.Parse((string)Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (A.salario + B.salario) / 2;
            Console.WriteLine("Salário Médio: " + media);

        }
    }
}
