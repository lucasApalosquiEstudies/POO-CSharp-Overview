using Aula05.Utilities;
using Aula05.Utilities.Generics;

namespace Aula05.Entities
{
    public class Produto
    {
        private const int QUANTIDADE_PADRAO = 1;
        private string _nome { get; set; }
        private double _valor { get; set; }
        private int _quantidade { get; set; }

        public Produto(string nome, double valor, int quantidade)
        {
            _nome = nome;
            _valor = valor;
            _quantidade = quantidade;
        }

        public Produto(string nome, double valor)
        {
            _nome = nome;
            _valor = valor;
            _quantidade = QUANTIDADE_PADRAO;
        }

        public void Pagar()
        {
            FormatarCabecalhoRecibo.FormatarCabecalho();
            InformacaoPagamento();
            MenuFrete();
        }

        public void InformacaoPagamento()
        {
            Console.WriteLine("    INFORMAÇÔES DO PRODUTO");
            FormatacaoPagamento.PularLinha();
            Console.WriteLine("Nome do Produto: " + _nome);
            Console.WriteLine("Preço do Produto: " + _valor);
            Console.WriteLine("Quantidade do Produto: " + _quantidade);
            Console.WriteLine("Valor total do Produto: " + CalcularValorProduto.ValorTotal(_quantidade, _valor));
            FormatacaoPagamento.TracadoDeLinha();
            FormatacaoPagamento.PularLinha();
        }

        public void MenuFrete()
        {
            Console.WriteLine("Selecione a opção de frete");
            Console.WriteLine("1 - Sedex");
            Console.WriteLine("2 - PAC");
            FormatacaoPagamento.TracadoDeLinha();
            string opcao = Console.ReadLine();
            
            while (opcao != "1" && opcao != "2")
            {
                Console.WriteLine("Opção inválida, tente novamente!");
                Console.WriteLine("Selecione a opção de frete");
                Console.WriteLine("1 - Sedex");
                Console.WriteLine("2 - PAC");
                FormatacaoPagamento.TracadoDeLinha();
                opcao = Console.ReadLine();
                FormatacaoPagamento.PularLinha();
                
            }

            Console.WriteLine("Qual a distancia percorrida?");
            string distanciaString = Console.ReadLine();
            int teste = int.Parse(distanciaString);
            while (teste - teste != 0)
            {
                Console.WriteLine("Distancia inválida Tente de novo:");
                Console.WriteLine("Qual a distancia percorrida? ");
                distanciaString = Console.ReadLine();
                teste = int.Parse(distanciaString);
            }
            int distancia = teste;

            if (opcao == "1")
            {
                FreteSedex sedex = new FreteSedex();
                sedex.GeradorDeFrete(distancia);
            }
            if (opcao == "2")
            {
                FretePAC pac = new FretePAC();
                pac.GeradorDeFrete(distancia);
            }


        }

    }
}
