using Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    public class IzmeniTim : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Tim tim = odo as Tim;
            Sesija.Broker.dajSesiju().updateJedanRed(tim);
            Clan cl = new Clan();
            cl.USLOVI = " TimID = " + tim.TimID;
            Sesija.Broker.dajSesiju().deleteViseRedova(cl);
            foreach (Clan clan in tim.Clanovi)
            {
                Sesija.Broker.dajSesiju().insertJedanRed(clan);
            }
            return true;
        }
    }
}
