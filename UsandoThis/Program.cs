using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoThis
{
    class Jogador
    {
        private int energia;
        private string nome;

        public Jogador(string nome)
        {
            this.nome = nome;
            energia = 100;
        }
        public int getEnergia()
        {
            return energia;
        }
        public string getNome()
        {
            return nome;
        }
        public void setEnergia(int e)
        {
            if (e < 0)
            {
                if (energia + e < 0)
                {
                    energia = 0;
                } else {
                    energia += e;
                }
            } else {
                if(energia + e > 100)
                {
                    energia = 100;
                } else {
                    energia += e;
                }
            }
        }

    }
    public class Calculos
    {
        public int v1;
        public int v2;

        public Calculos(int v1, int v2)
        {
            // O this está fazendo referencia ao v1 da Classe [linha 11] e não do Construtor
            this.v1 = v1;
            this.v2 = v2;
        }
        public int somar()
        {
            return v1 + v2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculos c = new Calculos(10, 2);
            Console.WriteLine(c.somar());

            /*---------------------------------------*/

            Jogador j1 = new Jogador("NoobMaster69");

            j1.setEnergia(-150);

            Console.WriteLine($"Nome : {j1.getNome()}");
            Console.WriteLine($"Energia : {j1.getEnergia()}"); 



            Console.ReadKey();
        }
    }
}
