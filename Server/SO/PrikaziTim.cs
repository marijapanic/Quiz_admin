using Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    public class PrikaziTim : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Tim t = new Tim();
            t = Sesija.Broker.dajSesiju().vratiJedanRedZaID(odo) as Tim;
            return t;
        }
    }
}
