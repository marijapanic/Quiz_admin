using Biblioteka;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    public class ObrisiTim : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            try
            {
                Tim t = odo as Tim;
                Clan cl = new Clan();
                cl.USLOVI = " TimID = " + t.TimID;
                Broker.dajSesiju().deleteViseRedova(cl);
                Duel d = new Duel();
                d.USLOVI = " Tim1ID = " + t.TimID;
                Broker.dajSesiju().deleteViseRedova(d);
                d.USLOVI = " Tim2ID = " + t.TimID;
                Broker.dajSesiju().deleteViseRedova(d);
                Broker.dajSesiju().deleteJedanRed(t);
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
