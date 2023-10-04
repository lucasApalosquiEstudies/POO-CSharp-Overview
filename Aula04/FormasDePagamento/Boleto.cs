using Aula03;
using CursoPOO.Aula04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04.FormasDePagamento
{
    internal class Boleto : IPagamento
    {

        private string _casa { get; set; }
        private string _complemento { get; set; }
        private int _numero { get; set; }

        public Boleto(string casa, string complemento, int numero)
        {
            _casa = casa;
            _complemento = complemento;
            _numero = numero;
        }

        public void Pagar(Carrinho carrinho)
        {
            Console.WriteLine("Boleto solicitado com sucesso!!");
            Console.WriteLine("Gerando boleto");
            Console.WriteLine("Enviando boleto para:\n" + FormatarEndereco());
        }

        private string FormatarEndereco()
        {
            return "Endereço: " + _casa + "\nComplemento: " + _complemento + "\nNumero: " + _numero; 
        }


    }
}
