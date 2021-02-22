using Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    public class KreirajNoviTim : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Tim t = new Tim();
            t.TimID = Sesija.Broker.dajSesiju().vratiNajveciID(odo);
            Sesija.Broker.dajSesiju().insertJedanRed(t);
            return t;
        }
    }
}
