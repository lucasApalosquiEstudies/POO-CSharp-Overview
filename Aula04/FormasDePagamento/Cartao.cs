using Aula03;
using CursoPOO.Aula04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04.FormasDePagamento
{
    internal class Cartao : IPagamento
    {
        private string _metodoPagamento { get; set; }

        public Cartao(string metodoDePagamento)
        {
            _metodoPagamento = metodoDePagamento;
        }

        public void Pagar(Carrinho carrinho)
        {
            Console.WriteLine("Compra no " + _metodoPagamento + " realizada com sucesso");
        }
    }
}
