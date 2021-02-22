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
    public class Duel : OpstiDomenskiObjekat
    {
        int duelID;
        DateTime datumVremeOdrzavanja;
        string voditelj;
        string rezultat;
        string tim1Poeni;
        string tim2Poeni;
        Tim timPrvi;
        Tim timDrugi;
        Kviz kviz;

        public int DuelID { get => duelID; set => duelID = value; }
        public DateTime DatumVremeOdrzavanja { get => datumVremeOdrzavanja; set => datumVremeOdrzavanja = value; }
        public string Voditelj { get => voditelj; set => voditelj = value; }
        public string Rezultat { get => rezultat; set => rezultat = value; }
        public string Tim1Poeni { get => tim1Poeni; set => tim1Poeni = value; }
        public string Tim2Poeni { get => tim2Poeni; set => tim2Poeni = value; }
        public Tim TimPrvi { get => timPrvi; set => timPrvi = value; }
        public Tim TimDrugi { get => timDrugi; set => timDrugi = value; }
        public Kviz Kviz { get => kviz; set => kviz = value; }

        #region ODO
        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Duel";
            }
        }
        [Browsable(false)]
        public string ObjekatID
        {
            get
            {
                return "DuelID";
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return " DuelID = " + DuelID;
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
                return "(DuelID) VALUES (" + DuelID + ")";
            }
        }
        [Browsable(false)]
        public string UpitZaUpdate
        {
            get
            {
                return " DatumVremeOdrzavanja ='" + DatumVremeOdrzavanja.ToString("yyyy-MM-dd HH:mm") + "', Voditelj ='" + Voditelj + "', Rezultat = '" + Rezultat +
                    "', Tim1Poeni ='" + Tim1Poeni + "', Tim2Poeni = '" + Tim2Poeni + "',  Tim1ID = " + TimPrvi.TimID + ", Tim2ID = " + TimDrugi.TimID + ", KvizID = " + Kviz.KvizID;
            }
        }



        public OpstiDomenskiObjekat citajRedTabele(DataRow red)
        {
            Duel d = new Duel();
            d.DuelID = Convert.ToInt32(red["DuelID"]);
            d.DatumVremeOdrzavanja = Convert.ToDateTime(red["DatumVremeOdrzavanja"]);
            d.Voditelj = red["Voditelj"].ToString();
            d.Rezultat = red["Rezultat"].ToString();

            d.Tim1Poeni = red["Tim1Poeni"].ToString();
            d.Tim2Poeni = red["Tim2Poeni"].ToString();
            d.Kviz = new Kviz();
            d.Kviz.KvizID = Convert.ToInt32(red["KvizID"]);
            d.TimPrvi = new Tim();
            d.TimPrvi.TimID = Convert.ToInt32(red["Tim1ID"]);
            d.TimDrugi = new Tim();
            d.TimDrugi.TimID = Convert.ToInt32(red["Tim2ID"]);
            return d;
        }
        #endregion
    }
}
