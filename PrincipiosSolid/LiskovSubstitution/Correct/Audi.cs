using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.LiskovSubstitution.Correct
{
    public class Audi : Coche
    {
        public override int numAsientosRenault()
        {
            return 4;
        }
    }
}
