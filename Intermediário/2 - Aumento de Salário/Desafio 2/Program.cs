using System;

namespace Desafio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste, novoSalario, percentual, porcentagem;
            salario = Convert.ToDouble(Console.ReadLine());

            //insira os valores corretos de acordo com o enunciado
            if (salario < 0.00)
            {
                return;
            }
            else if (salario >= 0.00 && salario <= 400.00)
            {
                porcentagem = 0.15;
            }
            else if (salario > 400.00 && salario <= 800.00)
            {
                porcentagem = 0.12;
            }
            else if (salario > 800.00 && salario <= 1200.00)
            {
                porcentagem = 0.10;
            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {
                porcentagem = 0.07;
            }
            else
            {
                porcentagem = 0.04;
            }
            try
            {
                reajuste = salario * porcentagem;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 100) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", porcentagem * 100);
            }
            catch (DivideByZeroException)
            {
                return;
            }
        }
    }
}
