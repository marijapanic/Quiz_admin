using Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    public class ZapamtiTim : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Tim t = odo as Tim;
            Sesija.Broker.dajSesiju().updateJedanRed(t);
            Clan cl = new Clan();
            cl.USLOVI = " TimID = " + t.TimID;
            Sesija.Broker.dajSesiju().deleteViseRedova(cl);
            foreach (Clan clan in t.Clanovi)
            {
                Sesija.Broker.dajSesiju().insertJedanRed(clan);
            }
            return true;
        }
    }
}
