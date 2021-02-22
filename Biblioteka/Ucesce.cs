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
    public class Ucesce : OpstiDomenskiObjekat
    {
        private DateTime datumUplate;
        private int iznos;
        private Tim tim;
        private Kviz kviz;

        public DateTime DatumUplate { get => datumUplate; set => datumUplate = value; }
        public int Iznos { get => iznos; set => iznos = value; }
        public Tim Tim { get => tim; set => tim = value; }
        public Kviz Kviz { get => kviz; set => kviz = value; }

        #region ODO
        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Ucesce";
            }
        }
        [Browsable(false)]
        public string ObjekatID
        {
            get
            {
                return null;
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return " KvizID = " + Kviz.KvizID + " AND TimID = " + Tim.TimID;
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
                return " VALUES (" + Kviz.KvizID + "," + Tim.TimID + ",'" + DatumUplate.ToString("yyyy-MM-dd")
                    + "', " + Iznos + ")";
            }
        }
        [Browsable(false)]
        public string UpitZaUpdate
        {
            get
            {
                return "DatumUplate ='" + DatumUplate.ToString() + "', Iznos = " + Iznos + "";
            }
        }
        public OpstiDomenskiObjekat citajRedTabele(DataRow red)
        {
            Ucesce u = new Ucesce();
            u.Kviz = new Kviz();
            u.Kviz.KvizID = Convert.ToInt32(red["KvizID"]);
            u.Tim = new Tim();
            u.Tim.TimID = Convert.ToInt32(red["TimID"]);
            u.DatumUplate = Convert.ToDateTime(red["DatumUplate"]);
            u.Iznos = Convert.ToInt32(red["Iznos"]);
            return u;
        }

        #endregion
    }
}
