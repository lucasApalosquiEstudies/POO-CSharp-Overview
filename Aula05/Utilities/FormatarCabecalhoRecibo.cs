namespace Aula05.Utilities
  
{
    using Aula05.Utilities.Generics;
    public static class FormatarCabecalhoRecibo
    {
        public static void FormatarCabecalho()
        {

            Console.WriteLine("           RECIBO");
            FormatacaoPagamento.TracadoDeLinha();
            Console.WriteLine("Avenida Tupi de Almeida, 45");
            Console.WriteLine("CEP - 20450-103 / São Paulo - SP");
            Console.WriteLine("CNPJ: " + FormatacaoPagamento.FormatarCnpj("12380976567843"));
            FormatacaoPagamento.TracadoDeLinha();
        }
    }
}
