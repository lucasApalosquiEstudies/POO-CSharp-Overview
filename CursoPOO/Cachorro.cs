using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseObjetoAtributoMetodo
{
    // CLASSE
    public class Cachorro
    {
        //ATRIBUTOS
        public string raca { get; set; }
        public string tamanho { get; set; }
        public bool temSede { get; set; }

        //MÉTODOS
        public void BeberAgua()
        {
            if (temSede == true) {
                Console.WriteLine("Bebeu agua!");
            }
            else { Console.WriteLine("não está com sede!"); }
        }

    }
}
