using Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    public class KreirajNoviDuel : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Duel d = new Duel();
            d.DuelID = Sesija.Broker.dajSesiju().vratiNajveciID(odo);
            Sesija.Broker.dajSesiju().insertJedanRed(d);
            return d;
        }
    }
}
