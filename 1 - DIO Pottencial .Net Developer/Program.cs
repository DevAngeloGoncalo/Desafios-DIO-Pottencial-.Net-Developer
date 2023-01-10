using System;

namespace desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            int n = 234;
            int p = 1, s = 0;
            while (n > 0)
            {
                int l = n % 10;
                // TODO: Crie as outras condições necessárias para a resolução do desafio:
                p *= l;
                s += l;
                n /= 10;
            }
            Console.WriteLine("aa");
            Console.WriteLine(p-s);
        }
    }
}
