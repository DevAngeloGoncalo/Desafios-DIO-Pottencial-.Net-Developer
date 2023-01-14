using System;
using System.Text.RegularExpressions;

namespace Desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] num = new int[n];

            // TODO: Crie as outras condições necessárias para a resolução do desafio:
            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(MajorityElement(num));
            
        }

        public static int MajorityElement(int[] nums)
        {
            int major = nums[0];
            int count = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    major = nums[i];
                }
                else
                {
                    if (major == nums[i])
                    {
                        count++;
                    }
                    else
                    {
                        count--;
                    }
                }
            }
            return major;
        }
    }
}
