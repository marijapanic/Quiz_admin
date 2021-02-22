using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteka;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sesija
{
    public class Broker
    {
        SqlCommand komanda;
        SqlTransaction transakcija;
        SqlDataReader citac;
        SqlConnection konekcija;

        static Broker instanca;
        public static Broker dajSesiju()
        {
            if (instanca == null) instanca = new Broker();
            return instanca;
        }

        public void otvoriKonekciju()
        {
            try
            {
                konekcija = new SqlConnection(@"Data Source=DESKTOP-ERQS16K;Initial Catalog=Kviz_projekat;Integrated Security=True");
                konekcija.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da uspostavi konekciju na bazu!");
                throw;
            }
        }

        public void zapocniTransakciju()
        {
            try
            {
                transakcija = konekcija.BeginTransaction();
                komanda = new SqlCommand("", konekcija, transakcija);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da započne transakciju!");
                throw;
            }
        }

        public void potvrdiTransakciju()
        {
            try
            {
                transakcija.Commit();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da potvrdi transakciju!");
                throw;
            }
        }

        public void ponistiTransakciju()
        {
            try
            {
                transakcija.Rollback();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da poništi transakciju!");
                throw;
            }
        }

        public void zatvoriKonekciju()
        {
            try
            {
                konekcija.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da zatvori konekciju!");
                throw;
            }
        }


        public List<OpstiDomenskiObjekat> vratiSve(OpstiDomenskiObjekat odo)
        {
            List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
            try
            {
                komanda.CommandText = "SELECT * FROM " + odo.NazivTabele;
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                foreach (DataRow red in tabela.Rows)
                {
                    lista.Add(odo.citajRedTabele(red));
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {
                citac.Close();
                throw;
            }
        }

        public void deleteJedanRed(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = "DELETE FROM " + odo.NazivTabele + " WHERE " + odo.UslovID;
                komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<OpstiDomenskiObjekat> vratiSveZaOpstiUslov(OpstiDomenskiObjekat odo)
        {
            List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
            try
            {
                komanda.CommandText = "SELECT * FROM " + odo.NazivTabele + " WHERE " + odo.OpstiUslov;
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                foreach (DataRow red in tabela.Rows)
                {
                    lista.Add(odo.citajRedTabele(red));
                }
                citac.Close();
                return lista;
            }
            catch (Exception)
            {
                citac.Close();
                throw;
            }
        }

        public void updateJedanRed(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = "UPDATE " + odo.NazivTabele + " SET " + odo.UpitZaUpdate + " WHERE " + odo.UslovID;
                komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int deleteViseRedova(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = "DELETE FROM " + odo.NazivTabele + " WHERE " + odo.OpstiUslov;
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        

        public OpstiDomenskiObjekat vratiJedanRedZaID(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = "SELECT * FROM " + odo.NazivTabele + " WHERE " + odo.UslovID;
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                citac.Close();
                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else return odo.citajRedTabele(tabela.Rows[0]);
            }
            catch (Exception)
            {
                citac.Close();
                throw;
            }
        }

        public int vratiNajveciID(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = "SELECT MAX(" + odo.ObjekatID + ") FROM " + odo.NazivTabele;
                try
                {
                    return Convert.ToInt32(komanda.ExecuteScalar()) + 1;
                }
                catch (Exception)
                {
                    return 1;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void insertJedanRed(OpstiDomenskiObjekat odo)
        {
            try
            {
                komanda.CommandText = "INSERT INTO " + odo.NazivTabele + " " + odo.UpitZaInsert;
                komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
