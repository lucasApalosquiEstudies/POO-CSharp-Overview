using Aula03;
using CursoPOO.Aula04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04.FormasDePagamento
{
    public class Pix : IPagamento
    {
        private string _chavePix { get; set; }

        public Pix(string chavePix)
        {
            _chavePix = chavePix;  
        }

        public void Pagar(Carrinho carrinho)
        {
            Console.WriteLine("Pix pago com sucesso!!");
            Console.WriteLine("Gerando comprovante...");
            GerarComprovantePix(carrinho);
        }

        private void GerarComprovantePix(Carrinho carrinho)
        {
            Console.WriteLine("Chave Pix: " + _chavePix);
            Console.WriteLine("Valor Pago: " + carrinho.ValorTotalCarrinho());
        }
    }
}
