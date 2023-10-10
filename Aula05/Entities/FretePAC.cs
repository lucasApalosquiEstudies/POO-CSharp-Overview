using Aula05.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05.Entities
{
    public class FretePAC : GerarFrete
    {
        public override string Nome()
        {
            return "PAC";
        }

        public override int Prazo()
        {
            return 2;
        }

        public override double Valor()
        {
            return 4.0;
        }
    }
}
