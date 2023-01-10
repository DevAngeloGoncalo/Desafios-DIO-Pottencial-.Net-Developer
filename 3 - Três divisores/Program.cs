using System;

namespace Desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                // TODO: Crie as outras condições necessárias para a resolução do desafio:
                if (n % i == 0)
                {
                    count++;
                }
                if (count > i)
                {
                    Console.WriteLine(false);
                }
            }
            Console.WriteLine(count == 3);
        }
    }
}
