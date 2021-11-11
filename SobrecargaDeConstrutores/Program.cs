using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaDeConstrutores
{
    public class Jogador
    {
        public int energia;
        public bool vivo=true;
        public string nome = "Jogador";

        // Vai inicializar um objeto quando intanciado da classe.
        // Toda classe tem um construtor, mesmo que nao declarado.

        //Método Construtor: //  parametro para o costrutor.

        public Jogador()
        {
        }
        public Jogador(string n)
        {
            energia= 100;
            vivo = true;
            nome = n;
        }

        public Jogador(string n, int e)
        {
            energia = e;
            vivo = true;
            nome = n;
        }

        public Jogador(string n, int e, bool v)
        {
            energia = e;
            vivo = v;
            nome = n;
        }

        public void info()
        {
            Console.WriteLine("Nome Jogador...: {0}\n", nome);
            Console.WriteLine("Energia Jogador: {0}\n", energia);
            Console.WriteLine("Estado Jogador.: {0}\n\n\n", vivo);

        }
    }


    class Program
    {
        static void Main()
        {
            Jogador j0 = new Jogador();
            Jogador j1 = new Jogador("Bruno");
            Jogador j2 = new Jogador("Luana", 50);
            Jogador j3 = new Jogador("Carlos", 50, true);

            j0.info();
            j1.info();
            j2.info();
            j3.info();

            Console.ReadLine();
        }

    }
}
