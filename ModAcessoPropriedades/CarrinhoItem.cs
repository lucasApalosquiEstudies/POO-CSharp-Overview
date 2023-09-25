using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ModAcessoPropriedades
{
    internal class CarrinhoItem
    {

        // membros constantes, sao aqueles que não vão sofrer alterações
        private const int Quantidade_Padrao = 1;
        private const string Cor_padrao = "principal";


        public string Nome { get; set; }
        private string _cor;
        private int _quantidade;

        //Logica nos construtores
        public string Cor
        {
            get { return _cor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _cor = Cor_padrao;
                }
                else
                {
                    _cor = value;
                }

            }
        }

        //Logica nos construtores
        public int Quantidade
        {
            get { return _quantidade; }
            set
            {
                if (value > 0)
                {
                    _quantidade = value;
                }
                else
                {
                    _quantidade = Quantidade_Padrao;
                }

            }
        }

        //Construtor
        public CarrinhoItem()
        {
            _quantidade = Quantidade_Padrao;
            _cor = "principal";
        }

        //Construtor com parametros e sobrecarga
        public CarrinhoItem(string nome, string cor, int quantidade) : base()
        {
            Nome = nome;
            _cor = cor;
            _quantidade = quantidade;
        }


        public static CarrinhoItem CriarItem(string nome, string cor, int quantidade)
        {
            var item = new CarrinhoItem();
            item.Nome = nome;
            item._quantidade = quantidade;
            item._cor = cor;
            return item;
        }

        //Método a nivel de instancia
        public void VerItem()
        {
            Console.WriteLine("Nome do Produto: " + Nome);
            Console.WriteLine("Cor do Produto: " + _cor);
            Console.WriteLine("Quantidade do Produto: " + _quantidade);
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
        }

        //Método a nivel de classe utilizando membro estático
        public static void VerItem(CarrinhoItem item)
        {
            Console.WriteLine("Nome do Produto: " + item.Nome);
            Console.WriteLine("Cor do Produto: " + item._cor);
            Console.WriteLine("Quantidade do Produto: " + item._quantidade);
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
        }

    }
}
