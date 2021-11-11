using System;

namespace FOR
{
    class Program
    {
        static void Main()
        {


            for (int i = 0; i < 10 ; i++)
            {

                Console.Write(i);

                if (i == 1)
                {
                    Console.Write('C');
                }

                else if (i < 3)
                {
                    Console.Write('H');
                }

                else if (i > 4)
                {
                    Console.Write('I');
                }


                else if (i == 6)
                {
                    Console.Write("L");
                }

                else if (i == 7)
                {
                    Console.Write("E");
                }


            }



        }
    }
}
