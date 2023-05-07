using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace objetosEClasses
{
    static public class Joga
    {
        /*
         * Se a classe for static necessáriamente todas as informações dentro da classe precisam ser static.
         * E como a classe é static, não é possível instanciar um objeto
         * Não sendo possível ter um construtor
         */

        static string nome;
        static int energia;
        static bool vivo;

        static public void iniciar(string n)
        {
            nome = n;
            energia = 100;
            vivo = true;
        }

        static public void info()
        {
            Console.WriteLine($"Nome Jogador: {nome}");
            Console.WriteLine($"Energia Jogador: {energia}");
            Console.WriteLine($"Estado Jogador: {vivo}\n");
        }
    }
    public class Jogador
    {
        /*Se não for definido o modificador de classe será [public] como default*/
        /*Propriedades da Classe*/
        public int energia;
        public bool vivo;
        public string nome;

        /*Criando um Método construtor, que é onde será definido os valores (Necessáriamente precisa ter o mesmo nome da Classe)*/
        public Jogador()
        {
            energia = 100;
            vivo = true;
            nome = "Jogador";
        }
        public Jogador(string n)
        {
            energia = 100;
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

        /*
         * Mais de um Construtor - Sobrecarga de Construtores
         * Funciona com métodos - Sobrecarga de Métodos
         */

        public void info()
        {
            Console.WriteLine($"Nome Jogador: {nome}");
            Console.WriteLine($"Energia Jogador: {energia}");
            Console.WriteLine($"Estado Jogador: {vivo}\n");
        }

        /*Criando um Método destrutor, sendo chamado antes de a classe ser destruida (Será sempre antecedido por um [~])*/
        ~Jogador()
        {
            Console.WriteLine("Jogador foi destruido");
        }

    }
    public class Inimigo
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
            Console.WriteLine("----------------");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                                        Criando um objeto / Instanciando
            O [new] reserva o espaço na memória para jogador, e cada um é performado de forma independente
            */

            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador("Lucas");
            Jogador j3 = new Jogador("NoobMaster69", 46);
            Jogador j4 = new Jogador("MeuMano", 0, false);

            j1.energia = 50; // Definindo a energia do jogador 1, pois a propriedade é pública

            j1.info();
            j2.info();
            j3.info();
            j4.info();

            Joga.iniciar("Teste"); // Como é uma classe static, não é possível instanciar um objeto, usando a própria Classe para chamar o método
            Joga.info();

            Inimigo i1 = new Inimigo("Zumbi");
            Inimigo i2 = new Inimigo("Pirado");
            Inimigo i3 = new Inimigo("SemPerna");

            Inimigo.alerta = true; // Todos os inimigos irão ter o mesmo valor, por alerta ser static

            i1.info();
            i2.info();
            i3.info();

            Console.ReadKey();
        }
    }
}
