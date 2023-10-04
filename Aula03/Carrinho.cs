using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    public class Carrinho
    {
        private List<Produto> produtos = new List<Produto>();

        public void AdicionarAoCarrinho(Produto produto)
        {
            produtos.Add(produto);
        }

        public void VerCarrinho()
        {
            if (produtos.Count == 0)
            {
                Console.WriteLine("Carrinho está vazio!!");
            }
            else
            {
                double valorTotalCarrinho = 0;
                foreach (Produto produto in produtos)
                {
                    produto.DescricaoItem();
                    valorTotalCarrinho += produto.ValorTotal();
                }
                Console.WriteLine("Valor total das compras: R$" + valorTotalCarrinho);
            }

        }

        public double ValorTotalCarrinho()
        {
            double valorTotalCarrinho = 0;
            if (produtos.Count > 0)
            {
                
                foreach (Produto produto in produtos)
                {
                    valorTotalCarrinho += produto.ValorTotal();
                }
            }
            else
            {
                valorTotalCarrinho = 0;
            }

            return valorTotalCarrinho;
        }


    }
}
