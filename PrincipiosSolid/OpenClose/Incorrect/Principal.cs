using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.OpenClose.Incorrect
{
    public class Principal
    {
        public static void main(String[] args)
        {
            Coche[] arrayCoches = {
            new Coche("Renault"),
            new Coche("Audi")
    };
            imprimirPrecioMedioCoche(arrayCoches);
        }

        public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches)
            {
                if (coche.Marca == "Renault") Console.WriteLine(18000);
                if (coche.Marca == "Audi") Console.WriteLine(25000);
            }
        }
    }
}
