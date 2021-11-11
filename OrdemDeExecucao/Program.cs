using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemDeExecucao
{
    class Program
    {
        class Base
        {
            public Base()
            {
                Console.WriteLine("Construtor da classe Base");
            }
        }

        class Derivada1: Base
        {
            public Derivada1()
            {
                Console.WriteLine("Construtor da classe Derivada 1");
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
