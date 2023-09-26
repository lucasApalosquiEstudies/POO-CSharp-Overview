using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    public class Produto
    {
        private string _nome { get; set; }
        private string _marca { get; set; }
        private double _preco { get; set; }
        private int _quantidade { get; set; }

        public Produto(string nome, string marca, double preco, int quantidade)
        {
            _nome = nome;
            _marca = marca;
            _preco = preco;
            _quantidade = quantidade;
        }

        public void DescricaoItem()
        {
            Console.WriteLine("Nome do produto: " + _nome);
            Console.WriteLine("Marca do produto: " + _marca);
            Console.WriteLine("Preço do produto: R$" + _preco);
            Console.WriteLine("Quantidade do produto: " + _quantidade);
            Console.WriteLine("Valor total do produto: R$" + ValorTotal());
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();

        }

        public double ValorTotal()
        {
            return _preco * _quantidade;
        }

    }
}
