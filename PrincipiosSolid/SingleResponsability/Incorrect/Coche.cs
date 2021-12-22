using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.SingleResponsability.Incorrect
{
    public class Coche
    {
        string marca;

        public Coche(string marca)
        {
            this.marca = marca;
        }

        string getMarcaCoche() { return marca; }

        void guardarCocheDB(Coche coche)
        {

        }
    }
}
