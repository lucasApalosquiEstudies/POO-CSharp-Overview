namespace Aula05.Infra.Interfaces
{
    public interface IGerarFrete
    {
        public void GeradorDeFrete(int distancia);
        public double CalcularFreteValor(int distancia);
        public int CalcularFretePrazo(int distancia);

       
    }
}
