using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected
{
    class Program
    {
        class Veiculo
        {
            public int velAtual;
            private int velMax; // rstringe o mesmo sobrente a classe base
            protected bool ligado; // permite o acesso ao membros pelas classes derivadas





            public Veiculo(int velMax)// Recebe parametro de entrada
            {
                velAtual = 0;
                this.velMax = velMax;
                ligado = false;
            }


            public bool getLigado() {

                return false;
            }
            public int getVelMax()
            {
                return velMax;
            }
        }

        class Carro : Veiculo // Derivada de veiculo
        {
            public string nome;
            public Carro(string nome, int velMax):base(velMax)
            {
                this.nome = nome;
                ligado = false;
            }

             

        }

        static void Main()
        {
            Carro carro = new Carro("Bonitão", 120);

            Console.WriteLine("Nome: {0}", carro.nome);
            Console.WriteLine("Vel.Maxima: {0}", carro.getVelMax());
            Console.WriteLine("Ligado: {0}", carro.getLigado());
        }
    }
}
