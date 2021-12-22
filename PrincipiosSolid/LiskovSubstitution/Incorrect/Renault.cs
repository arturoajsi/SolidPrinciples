using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.LiskovSubstitution.Incorrect
{
    public class Renault : Coche
    {
        public override int numAsientosRenault()
        {
            throw new NotImplementedException();
        }
    }
}
