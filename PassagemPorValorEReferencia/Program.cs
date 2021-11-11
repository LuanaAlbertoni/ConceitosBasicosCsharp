using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassagemPorValorEReferencia
{
    class Program
    {
        static void Main()
        {
            int num = 10;
            dobrar(ref num);
            Console.WriteLine(num);
            Console.ReadLine();
        }

        // Usa o mesmo endereço de memória da variavel que foi passada por argumento
        static void dobrar(ref int valor)
        {
            valor *= 2;

        }

        // Cria outra posição na memoria e utiliza a nova posição no método
        static void dobrar2(int valor)
        {
            valor *= 2;

        }
    }
}
  