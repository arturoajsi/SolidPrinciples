using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.OpenClose.Incorrect
{
    public class Coche
    {
        private string marca;

        public string Marca { get; set; }

        public Coche(string marca)
        {
            this.marca = marca;
        }

        string precioMedioCoche() { return marca; }
    }
}
