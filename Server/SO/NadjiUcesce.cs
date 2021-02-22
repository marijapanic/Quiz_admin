using Biblioteka;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    public class NadjiUcesce : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            return Broker.dajSesiju().vratiSveZaOpstiUslov(odo).OfType<Ucesce>().ToList<Ucesce>();
        }
    }
}
