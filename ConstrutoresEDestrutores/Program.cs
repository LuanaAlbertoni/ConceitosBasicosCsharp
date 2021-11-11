using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutoresEDestrutores
{
    public class Jogador
    {
        public int energia;
        public bool vivo;
        public string nome;

        // Vai inicializar um objeto quando intanciado da classe.
        // Toda classe tem um construtor, mesmo que nao declarado.

        //Método Construtor: //  parametro para o costrutor.
        public Jogador(string n)
        {
            energia = 100;
            vivo = true;
            nome = n;
        }

        ~Jogador()
        {
            Console.WriteLine("Jogador deletado", nome);
        }

    }


    class Program
    {
        static void Main()
        {
            string[] nome = new string[5];
            Console.WriteLine("Digite o nome do Jogador 1: ");
            nome[0] = Console.ReadLine();
            Jogador j1 = new Jogador(nome[0]);
            Jogador j2 = new Jogador("Carlos");

            j1.energia = 50;

            Console.WriteLine("Energia do jogadir 1: {0}", j1.nome);
            Console.WriteLine("Energia do jogadir 2: {0}", j2.nome);
            Console.ReadLine();

        }

    }

}
