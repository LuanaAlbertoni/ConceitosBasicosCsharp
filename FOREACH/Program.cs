using System;

namespace FOREACH
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leitura dos elementos de uma coleção
            int[] num = new int[3] { 11, 22, 33 };

            foreach(int n in num)
            {
                Console.WriteLine(n);
            }
        }
    }
}
