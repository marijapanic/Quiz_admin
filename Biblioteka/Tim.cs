using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    [Serializable]
    public class Tim : OpstiDomenskiObjekat
    {
        int timID;
        string nazivTima;
        BindingList<Clan> clanovi;
        BindingList<Ucesce> listaUcescaTima;

        public int TimID { get => timID; set => timID = value; }
        [DisplayName("Naziv tima")]
        public string Naziv { get => nazivTima; set => nazivTima = value; }
        public BindingList<Clan> Clanovi { get => clanovi; set => clanovi = value; }
        public BindingList<Ucesce> ListaUcescaTima { get => listaUcescaTima; set => listaUcescaTima = value; }
        public Tim()
        {
            clanovi = new BindingList<Clan>();
            listaUcescaTima = new BindingList<Ucesce>();
        }
        public override string ToString()
        {
            return nazivTima;
        }

        #region ODO
        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Tim";
            }
        }
        [Browsable(false)]
        public string ObjekatID
        {
            get
            {
                return "TimID";
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return " TimID = " + timID;
            }
        }
        public string USLOVI;

        [Browsable(false)]
        public string OpstiUslov
        {
            get
            {
                return USLOVI;
            }
        }
        [Browsable(false)]
        public string UpitZaInsert
        {
            get
            {
                return "(TimID) VALUES (" + timID + ")";
            }
        }
        [Browsable(false)]
        public string UpitZaUpdate
        {
            get
            {
                return " NazivTima = '" + nazivTima + "'";
            }
        }
        public OpstiDomenskiObjekat citajRedTabele(DataRow red)
        {
            Tim t = new Tim();
            t.timID = Convert.ToInt32(red["TimID"]);
            t.nazivTima = red["NazivTima"].ToString();
            return t;
        }
        #endregion
    }
}
