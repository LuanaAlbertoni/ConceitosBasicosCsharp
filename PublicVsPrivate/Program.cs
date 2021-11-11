using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PublicVsPrivate
{
    class Jogador
    {
        private  int energia;
        private  string nome;

        public Jogador(string nome)
        {
            this.nome = nome;
            energia = 100;
        }

        // Criar um método para retornar o que é privado
        public int getEnergia()
        {
            return energia;
        }

        public string  getNome()
        {
            return nome;
        }

        public void setEnergia(int e)
        {
            if(e < 0)
            {
                if (energia - e < 0)
                {
                    energia = 0;
                }
                else
                {
                    energia += e;
                }
            }
            else if (e>0)
            {
                if (energia + e > 100)
                {
                    energia = 100;
                }
                else
                {
                    energia += 100;
                }
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Jogador j1 = new Jogador("Luana");

            j1.setEnergia(-30);

            Console.WriteLine("Nome: {0}", j1.getNome());
            Console.WriteLine("Energia: {0}", j1.getEnergia());

            Console.ReadLine();

        }
    }
}
