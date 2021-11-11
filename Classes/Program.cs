using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    
    // Tipo de dados compostos por membros: propiedades das variaveis e funcionalidades da classe

   public class Jogador
    {
        public int energia = 100;
        public bool vivo = true;

    }
    
    
    class Program
    {
        static void Main()
        {
            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador();
            Jogador j3 = new Jogador();

            j1.energia = 50;

            Console.Write("Energia do jogadir 1: {0}", j1.energia);
            Console.Write("Energia do jogadir 2: {0}", j2.energia);
            Console.ReadLine();
        }
    }
}
