using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;



namespace Biblioteka
{
    [Serializable]
    public class Administrator : OpstiDomenskiObjekat
    {


        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }


        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
        #region ODO

        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Administrator";
            }
        }
        [Browsable(false)]
        public string ObjekatID
        {
            get
            {
                return "KorisnickoIme";
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return " KorisnickoIme = '" + KorisnickoIme + "' AND Sifra = '" + Sifra + "'";
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
                return "(KorisnickoIme) VALUES (" + KorisnickoIme + ")";
            }
        }
        [Browsable(false)]
        public string UpitZaUpdate
        {
            get
            {
                return " Ime = '" + Ime + "', Prezime = '" + Prezime + "' ";
            }
        }

        public OpstiDomenskiObjekat citajRedTabele(DataRow red)
        {
            Administrator admin = new Administrator();
            admin.Ime = red["Ime"].ToString();
            admin.Prezime = red["Prezime"].ToString();
            return admin;
        }

        #endregion
    }
}
