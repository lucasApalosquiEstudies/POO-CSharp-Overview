namespace Aula05.Utilities.Generics
{
    public static class FormatacaoPagamento
    {

        public static void TracadoDeLinha()
        {

            Console.WriteLine("--------------------------------");
        }

        public static void PularLinha()
        {
            Console.WriteLine();
        }

        public static string FormatarCnpj(string Cnpj)
        {
            return Convert.ToUInt64(Cnpj).ToString(@"00\.000\.000\/0000\-00");
        }

    }
}
