using Biblioteka;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SO
{
    public abstract class OpstaSO
    {
        public Object IzvrsiSO(OpstiDomenskiObjekat odo)
        {

            Object rez = null;
            try
            {
                Broker.dajSesiju().otvoriKonekciju();
                Broker.dajSesiju().zapocniTransakciju();
                rez = Izvrsi(odo);
                Broker.dajSesiju().potvrdiTransakciju();
            }
            catch (Exception)
            {
                Broker.dajSesiju().ponistiTransakciju();
            }
            finally
            {
                Broker.dajSesiju().zatvoriKonekciju();
            }
            return rez;
        }
        public abstract Object Izvrsi(OpstiDomenskiObjekat odo);
    }
}
