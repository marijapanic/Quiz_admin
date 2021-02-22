using Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    public class ZapamtiUcesca : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Tim t = odo as Tim;
            foreach (Ucesce u in t.ListaUcescaTima)
            {
                Sesija.Broker.dajSesiju().insertJedanRed(u);
            }
            return true;
        }
    }
}
