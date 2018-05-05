using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vampira
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            int anonascimento; string nome;

            Console.WriteLine("Olá, por favor insira o Ano de nascimento");
            anonascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Olá, Insira o Nome");
            nome =Console.ReadLine();
            Console.ReadKey();
            int res = DateTime.Now.Year - anonascimento;
            Console.ReadKey();
            Console.WriteLine(" olá " + nome + " tens " + res + " Anos de Idade");
            Console.ReadKey();
        }
    }
}
