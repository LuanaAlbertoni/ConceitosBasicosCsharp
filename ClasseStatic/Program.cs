using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseStatic
{
    static class Jogador
    {
        static public int energia;
        static public bool vivo = true;
        static public string nome = "Jogador";

        static public void iniciar(string n)
        {
            energia = 100;
            vivo = true;
            nome = n;
        }

        static public void info()
        {
            Console.WriteLine("Nome Jogador...: {0}\n", nome);
            Console.WriteLine("Energia Jogador: {0}\n", energia);
            Console.WriteLine("Estado Jogador.: {0}\n\n\n", vivo);

        }

        class Inimigo
        {
            static public bool alerta;
            public string nome;
            public Inimigo(string n)
            {
                alerta = false;
                nome = n;
            }

            public void info()
            {
                Console.WriteLine(nome);
                Console.WriteLine(alerta);
                Console.WriteLine("--------------");
            }
        }
        class Program
        {
            static void Main()
            {

                Jogador.iniciar("Luana");
                Jogador.info();

                Inimigo i1 = new Inimigo("Doido");
                Inimigo i2 = new Inimigo("Maluco");
                Inimigo i3 = new Inimigo("Pirado");

                Inimigo.alerta = true;

                i1.info();
                i2.info();
                i3.info();

                Console.ReadLine();
            }

        }
    }
}
