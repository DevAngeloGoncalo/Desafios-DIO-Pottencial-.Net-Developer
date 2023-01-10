using System;

namespace Desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qt = int.Parse(Console.ReadLine());
            // TODO: Crie as outras condições necessárias para a resolução do desafio:
            string[] v = new string[2];


        for (int contador= 0; contador < qt; contador++)
            {
                v = Console.ReadLine().Split(" ");
                string a = v[0];
                string b = v[1];

                if (b.Length > a.Length)
                    Console.WriteLine("nao encaixa");
                else if (a.EndsWith(b))
                    Console.WriteLine("encaixa");
                else
                    Console.WriteLine("nao encaixa");

            }
        }
    }
}
