using System;

namespace METODOS
{
    class Program
    {
        //STATIC: Os métodos utilizados dentro devem ser sempre statics

        //Bloco de instruções que podem ser chamados para execução a qualquer momento
        //Parametros de entrada
        //Métodos que retornam valores
        static void Main(string[] args)
        {
            int v1, v2, r;
            v1 = Convert.ToInt32(Console.ReadLine());
            v2 = Convert.ToInt32(Console.ReadLine());
            r=soma(v1,v2);
            Console.WriteLine("A soma de {0} e {1} é: {2}", v1, v2, r);
        }

        //void - não retorna nada
        //Nome - comportamneto referente ao método
                         // dois paramentros/ argumentos de entrada
        static int soma(int n1, int n2)
        {
            int res = n1 + n2;
            return res;


        }
    }
}
 