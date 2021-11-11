using System;

namespace WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            int i = 0;
            while (i<num.Length)
            {
                num[i] = 0;

                Console.WriteLine("CFB Cursos");
                Console.WriteLine(num[i]);


                i++;
            }
            Console.WriteLine("Fim do loop");
        }
    }
}
