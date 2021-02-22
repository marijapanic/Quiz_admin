using Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    public class PrikaziDuel : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Duel d = new Duel();
            d = Sesija.Broker.dajSesiju().vratiJedanRedZaID(odo) as Duel;
            return d;
        }
    }
}
