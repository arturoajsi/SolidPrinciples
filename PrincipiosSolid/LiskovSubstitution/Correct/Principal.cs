using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.LiskovSubstitution.Correct
{
    public class Principal
    {
        static void Main(string[] args)
        {

            Coche[] arrayCoches = {
            new Renault(),
            new Audi(),
            new Mercedes()
        };
            imprimirNumAsientos(arrayCoches);
        }

        public static void imprimirNumAsientos(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches)
            {
                Console.WriteLine(coche.numAsientosRenault());
            }
        }

    }
}
