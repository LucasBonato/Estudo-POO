using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Veiculo // Classe Base
    {
        public int rodas;
        public int velMax;
        private bool ligado;

        public Veiculo(int rodas)
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
        public int getRodas()
        {
            return rodas;
        }
        public void setRodas(int rodas)
        {
            if (rodas < 0)
            {
                this.rodas = 0;
            } else if (rodas > 40) {
                this.rodas = 40;
            } else {
                this.rodas = rodas;
            }
        }
    }
    public class Carro : Veiculo // Classe Derivada
    {
        public string nome;
        public string cor;
        public Carro(string nome, string cor):base(4) // [:base()] está iniciando o constructor de Veiculos
        {
            desligar();
            velMax = 120;
            this.nome = nome;
            this.cor = cor;
        }
    }
    public class CarroCombate : Carro // Encadeamento de Classes Derivadas
    {
        public int municao;
        public CarroCombate():base("Carro de Combate", "Verde")
        {
            velMax = 200;
            municao = 100;
            setRodas(8);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Rapido", "Vermelho");
            CarroCombate cc1 = new CarroCombate();

            c1.ligar();

            Console.WriteLine($"Cor: {c1.cor}");
            Console.WriteLine($"Nome: {c1.nome}");
            Console.WriteLine($"Rodas: {c1.getRodas()}");
            Console.WriteLine($"Velocidade Máxima: {c1.velMax}");
            Console.WriteLine($"Ligado: {c1.getLigado()}\n\n");

            Console.WriteLine($"Cor: {cc1.cor}");
            Console.WriteLine($"Nome: {cc1.nome}");
            Console.WriteLine($"Rodas: {cc1.getRodas()}");
            Console.WriteLine($"Velocidade Máxima: {cc1.velMax}");
            Console.WriteLine($"Ligado: {cc1.getLigado()}");
            Console.WriteLine($"Munição: {cc1.municao}");

            Console.ReadKey();
        }
    }
}
