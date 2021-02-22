using Biblioteka;
using Sesija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    public class UcitajClanove : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Tim tim = odo as Tim;
            Clan cl = new Clan();
            cl.USLOVI = " TimID = " + tim.TimID;
            List<Clan> listaClanova = Broker.dajSesiju().vratiSveZaOpstiUslov(cl).OfType<Clan>().ToList<Clan>();
            tim.Clanovi = new BindingList<Clan>(listaClanova);
            return listaClanova;

        }
    }
}
