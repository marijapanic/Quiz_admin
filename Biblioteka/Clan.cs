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
    public class Clan : OpstiDomenskiObjekat
    {
        int redBr;
        string jmbg;
        string ime;
        string prezime;
        DateTime datumRodjenja;
        int timID;
        public string Jmbg { get => jmbg; set => jmbg = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public int RedBr { get => redBr; set => redBr = value; }
        public int TimID { get => timID; set => timID = value; }


        #region ODO
        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Clan";
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
                return " TimID =" + TimID + " AND RedBr = " + RedBr;
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
                return "(TimID, RedBr, JMBG, Ime, Prezime, DatumRodjenja) VALUES ("
                    + TimID + "," + RedBr + ",'" + Jmbg + "', '" + Ime + "', '" + Prezime + "', '"
                    + DatumRodjenja.ToString("yyyy-MM-dd") + "')";
            }
        }
        [Browsable(false)]
        public string UpitZaUpdate
        {
            get
            {
                return null;
            }
        }



        public OpstiDomenskiObjekat citajRedTabele(DataRow red)
        {
            Clan c = new Clan();
            c.TimID = Convert.ToInt32(red["TimID"]);
            c.RedBr = Convert.ToInt32(red["RedBr"]);
            c.Jmbg = red["JMBG"].ToString();
            c.Ime = red["Ime"].ToString(); ;
            c.Prezime = red["Prezime"].ToString(); ;
            c.DatumRodjenja = Convert.ToDateTime(red["DatumRodjenja"]);
            return c;
        }
        #endregion
    }
}
