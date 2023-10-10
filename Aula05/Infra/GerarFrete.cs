

using Aula05.Infra.Interfaces;

namespace Aula05.Infra
{
    public abstract class GerarFrete : IGerarFrete
    {
        public abstract string Nome();
        public abstract double Valor();
        public abstract int Prazo();


        public void GeradorDeFrete(int distancia)
        {
            Console.WriteLine("Tipo: " + Nome() + "| Valor: R$" + CalcularFreteValor(distancia) + "| Prazo: "
                + Prazo() + " Dias");

        }

        public double CalcularFreteValor(int distancia)
        {
            return Valor() * distancia;
        }

        public int CalcularFretePrazo(int distancia)
        {
            return (Prazo() * distancia) / 24;
        }

  

    }
}
