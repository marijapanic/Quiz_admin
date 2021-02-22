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
    public class Kviz : OpstiDomenskiObjekat
    {
        int kvizID;
        string nazivKviza;
        private BindingList<Tim> timovi;


        public int KvizID { get => kvizID; set => kvizID = value; }
        public string NazivKviza { get => nazivKviza; set => nazivKviza = value; }
        public BindingList<Tim> Timovi { get => timovi; set => timovi = value; }
        public Kviz()
        {
            timovi = new BindingList<Tim>();
        }
        public override string ToString()
        {
            return nazivKviza;
        }

        #region ODO
        [Browsable(false)]
        public string NazivTabele
        {
            get
            {
                return "Kviz";
            }
        }
        [Browsable(false)]
        public string ObjekatID
        {
            get
            {
                return "KvizID";
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return " KvizID = " + KvizID;
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
                return "(KvizID) VALUES (" + KvizID + ")";
            }
        }
        [Browsable(false)]
        public string UpitZaUpdate
        {
            get
            {
                return " NazivKviza ='" + NazivKviza + "'";
            }
        }
        public OpstiDomenskiObjekat citajRedTabele(DataRow red)
        {
            Kviz k = new Kviz();
            k.KvizID = Convert.ToInt32(red["KvizID"]);
            k.NazivKviza = red["NazivKviza"].ToString();

            return k;
        }
        #endregion
    }

}
