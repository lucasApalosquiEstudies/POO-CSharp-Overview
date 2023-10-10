
using Aula05.Infra;

namespace Aula05.Entities
{
    public class FreteSedex : GerarFrete
    {


        public override string Nome()
        {
            return "Sedex";
        }

        public override int Prazo()
        {
            return 3;
        }

        public override double Valor()
        {
            return 2.5;
        }
    }
}
