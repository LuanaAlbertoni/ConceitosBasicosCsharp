using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Veiculo // Classe base
    {
        private int rodas;
        public int velMax;

        private bool ligado;

        public Veiculo (int rodas) // Construtor na classe base
        {
            this.rodas = rodas;
        }

        public void ligar()
        {
            ligado = true;
        }
        public void desligar()
        {
            ligado = false;
        }

        public string getLigado()
        {
            return (ligado ? "sim" : "não");
        }
        public int getRodas() // Método
        {
            return rodas;
        }

        public void setRodas(int rodas)
        {
            if (rodas < 0)
            {
                this.rodas = 0;
            } 
            else if (rodas>40) 
            {
                this.rodas = 40;
            }
            else
            {
                this.rodas = rodas;
            }
        }
    }

     //Derivada    //Base
    class Carro : Veiculo{ // A classe derivada herda a classe base

        public string nome;
        public string cor;
        public Carro(string nome, string cor): base(4) // Cosntrutor da classe base que precisa de um argumento
        {
            desligar();
            velMax = 120;
            this.nome = nome;
            this.cor = cor;
        }
    }

    class CarroCombate : Carro
    {
        public int monicao;

        public CarroCombate() : base("Carro de combate", "Verde")
        {
            monicao = 100;
            setRodas(6);
        }


    }
    class Program
    {
        static void Main()
        {
            Carro c1 = new Carro("rapidao", "vermelho");
            CarroCombate cc1 = new CarroCombate();

            Console.WriteLine("Cor..............: {0}", c1.cor);
            Console.WriteLine("Nome.............: {0}", c1.nome);
            Console.WriteLine("rodas............: {0}", c1.getRodas());
            Console.WriteLine("Velocidade Máxima: {0}", c1.velMax);
            Console.WriteLine("Ligado...........: {0}", c1.getLigado());

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Cor..............: {0}", cc1.cor);
            Console.WriteLine("Nome.............: {0}", cc1.nome);
            Console.WriteLine("rodas............: {0}", cc1.getRodas());
            Console.WriteLine("Velocidade Máxima: {0}", cc1.velMax);
            Console.WriteLine("Ligado...........: {0}", cc1.getLigado());
            Console.WriteLine("Munição..........: {0}", cc1.monicao);




            Console.ReadLine();
        }
    }
}
