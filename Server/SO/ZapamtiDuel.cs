using Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    public class ZapamtiDuel : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Duel d = odo as Duel;
            Sesija.Broker.dajSesiju().updateJedanRed(d);
            return true;
        }
    }
}
