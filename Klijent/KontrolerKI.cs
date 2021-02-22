using Biblioteka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public class KontrolerKI
    {
        static Komunikacija komunikacija;
        public static Administrator admin;
        static Tim tim;
        static Clan clan;
        static Duel duel;
        static Kviz kviz;
        static Ucesce ucesce;
        static BindingList<Ucesce> listaUcesca;

        internal void PrikaziDuele(DataGridView dgvDueli)
        {
            duel = new Duel();
            List<Tim> lista = komunikacija.VratiSveTimove() as List<Tim>;
            List<Duel> dueli = komunikacija.VratiSveDuele() as List<Duel>;
            List<Kviz> kvizovi = komunikacija.VratiSveKvizove() as List<Kviz>;

            foreach (Duel duel in dueli)
            {
                foreach (Kviz kviz in kvizovi)
                {
                    if (duel.Kviz.KvizID == kviz.KvizID)
                    {
                        duel.Kviz = kviz;
                    }
                }
            }

            foreach (Duel d in dueli)
            {
                foreach (Tim tim in lista)
                {
                    if (d.TimPrvi.TimID == tim.TimID)
                        d.TimPrvi = tim;
                    if (d.TimDrugi.TimID == tim.TimID)
                        d.TimDrugi = tim;
                }
            }
            dgvDueli.DataSource = dueli;
        }

        internal void PrikaziDetaljeODuelu(Duel duel, TextBox txtDatumVreme, TextBox txtKviz, TextBox txtVoditelj, TextBox txtTim1, TextBox txtTim2, TextBox txtP1, TextBox txtP2, DetaljiODuelu forma)
        {
            if (duel == null)
            {
                MessageBox.Show("Sistem nije učitao duel!");
                forma.Close();
                return;
            }
            else
            {
                txtDatumVreme.Text = duel.DatumVremeOdrzavanja.ToString();
                txtKviz.Text = duel.Kviz.NazivKviza;
                txtVoditelj.Text = duel.Voditelj;

                txtTim1.Text = duel.TimPrvi.Naziv;
                txtTim2.Text = duel.TimDrugi.Naziv;
                txtP1.Text = duel.Rezultat.Split('-')[0].ToString();
                txtP2.Text = duel.Rezultat.Split('-')[1].ToString();
            }
        }

        internal bool PrikaziDuel(DataGridView dgvDueli)
        {
            try
            {
                duel = dgvDueli.CurrentRow.DataBoundItem as Duel;
                duel = komunikacija.PrikaziDuel(duel) as Duel;
                if (duel == null)
                {
                    MessageBox.Show("Sistem nije učitao duel!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je učitao duel!");
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali duel!");
                return false;
            }
        }

        internal void PretraziDuelePoKriterijumu(TextBox txtDatum, TextBox txtVreme, ComboBox cmbKviz, DataGridView dgvDueli, PretragaDuela forma)
        {
            duel = new Duel();
            string uslov = "";
            if (txtDatum.Text != "")
            {
                // izvuci posebno godinu, mesec i dan
                string[] datum = txtDatum.Text.Split('.');
                try
                {
                    uslov = " DATEPART(yyyy, DatumVremeOdrzavanja) = " + datum[2] + " AND DATEPART(MM, DatumVremeOdrzavanja) = " + datum[1] +
                                " AND DATEPART(dd, DatumVremeOdrzavanja) = " + datum[0] + "";
                }
                catch (Exception)
                {

                    MessageBox.Show("Pogresan datum, dd.MM.yyyy, ovo je format");
                    return;
                }
            }
            if (txtVreme.Text != "")
            {
                string[] vreme = txtVreme.Text.Split(':');
                if (uslov != "")
                {
                    try
                    {
                        // izvuci vreme
                        uslov += " AND DATEPART(hour, DatumVremeOdrzavanja) = " + vreme[0] + " AND DATEPART(minute, DatumVremeOdrzavanja) = " + vreme[1] + "";
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Pogresno vreme, hh.mm, ovo je format");
                        return;
                    }
                }
                else
                {
                    try
                    {
                        uslov = " DATEPART(hour, DatumVremeOdrzavanja) = " + vreme[0] + " AND DATEPART(minute, DatumVremeOdrzavanja) = " + vreme[1] + "";
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Pogresno vreme, hh.mm, ovo je format");
                        return;
                    }
                }
            }
            if (cmbKviz.SelectedItem != null)
            {
                Kviz kviz = cmbKviz.SelectedItem as Kviz;
                if (uslov != "")
                {
                    uslov += " AND KvizID = " + kviz.KvizID + "";
                }
                else
                {
                    uslov = " KvizID = " + kviz.KvizID + "";
                }
            }
            if (uslov != "")
            {
                duel.USLOVI = uslov;
            }
            else
            {
                duel.USLOVI = " DATEPART(yyyy, DatumVremeOdrzavanja) > " + 1900 + "";
            }
            List<Duel> pretraga = komunikacija.PronadjiDuele(duel) as List<Duel>;
            List<Tim> lista = komunikacija.VratiSveTimove() as List<Tim>;
            dgvDueli.DataSource = pretraga;
            List<Kviz> kvizovi = komunikacija.VratiSveKvizove() as List<Kviz>;
            foreach (Duel d in pretraga)
            {
                foreach (Kviz kviz in kvizovi)
                {
                    if (d.Kviz.KvizID == kviz.KvizID)
                    {
                        d.Kviz = kviz;
                    }
                }
            }
            foreach (Duel d in pretraga)
            {
                foreach (Tim tim in lista)
                {
                    if (d.TimPrvi.TimID == tim.TimID)
                        d.TimPrvi = tim;
                    if (d.TimDrugi.TimID == tim.TimID)
                        d.TimDrugi = tim;
                }
            }
            if (pretraga.Count == 0)
            {
                MessageBox.Show("Sistem ne može da nađe duele po zadatim vrednostima!");
                forma.Close();
                return;
            }
            MessageBox.Show("Sistem je našao duele po zadatim vrednostima!");
        }

        internal void PrikaziDetaljeOTimu(DataGridView dgvTimovi, TextBox txtKriterijum)
        {
            tim = new Tim();
            List<Tim> lista = komunikacija.VratiSveTimove() as List<Tim>;

            dgvTimovi.DataSource = lista;
        }

        internal void UcitajKvizove(ComboBox cmbKviz, Form forma)
        {
            List<Kviz> lista = (List<Kviz>)komunikacija.VratiSveKvizove();
            //List<Ekipa> m = new List<Ekipa>(); za alternativni scenario kod preduslova
            if (lista.Count == 0)
            {
                MessageBox.Show("Sistem ne može da pronađe listu kvizova!");
                forma.Close();
                return;
            }
            else
            {
                cmbKviz.DataSource = lista;
                cmbKviz.SelectedItem = null;
                MessageBox.Show("Sistem je pronašao listu kvizova!");
            }
        }

        internal bool SacuvajDuel(TextBox txtDatumVreme, TextBox txtVoditelj, TextBox txtRezultat, ComboBox cmbTim1, ComboBox cmbTim2, TextBox txtD1, ComboBox cmbKviz, TextBox txtG1, Button btnSacuvaj)
        {
            try
            {
                duel.DatumVremeOdrzavanja = DateTime.ParseExact(txtDatumVreme.Text, "dd.MM.yyyy HH:mm", null);
            }
            catch (Exception)
            {
                MessageBox.Show("Datum mora biti u formatu dd.MM.yyyy HH:mm!");
                return false;
            }
            duel.Kviz = cmbKviz.SelectedItem as Kviz;
            if (duel.Kviz == null)
            {
                MessageBox.Show("Niste odabrali kviz u okviru kog se odigrava duel!");
                return false;
            }
            duel.Voditelj = txtVoditelj.Text;
            if (duel.Voditelj == "")
            {
                MessageBox.Show("Niste uneli voditelja!");
                return false;
            }
            duel.Rezultat = txtRezultat.Text;
            if (duel.Rezultat == "")
            {
                MessageBox.Show("Niste uneli rezultat!");
                return false;
            }

            duel.TimPrvi = cmbTim1.SelectedItem as Tim;
            if (duel.TimPrvi == null)
            {
                MessageBox.Show("Niste odabrali prvi tim!");
                return false;
            }
            duel.Tim1Poeni = txtD1.Text;
            if (duel.Tim1Poeni == "")
            {
                MessageBox.Show("Niste uneli podatke o poenima\n za tim 1!");
                return false;
            }
            duel.TimDrugi = cmbTim2.SelectedItem as Tim;
            if (duel.TimDrugi == null)
            {
                MessageBox.Show("Niste odabrali tim 2!");
                return false;
            }
            if (duel.TimPrvi.TimID == duel.TimDrugi.TimID)
            {
                MessageBox.Show("Tim ne može da igra sam sa sobom!");
                return false;
            }
            duel.Tim2Poeni = txtG1.Text;
            if (duel.Tim2Poeni == "")
            {
                MessageBox.Show("Niste uneli podatke o poenima\n za tim 2!");
                return false;
            }
            // ne sme isti duel u kvizu u to vreme, ne sme drugi duel u vec zakazano vreme
            duel.USLOVI = " DATEDIFF(minute, DatumVremeOdrzavanja, '" + duel.DatumVremeOdrzavanja.ToString("yyyy-MM-dd HH:mm") +
                "') = 0 AND KvizID = " + duel.Kviz.KvizID + " AND Tim1ID = " + duel.TimPrvi.TimID +
                " AND Tim2ID = " + duel.TimDrugi.TimID + "";

            List<Duel> rez = komunikacija.DuelUIstoVreme(duel) as List<Duel>;
            if (rez.Count != 0)
            {
                MessageBox.Show("Već postoji isti duel koji se održava u kvizu u ovo vreme!");
                return false;
            }
            duel.USLOVI = " DATEDIFF(minute, DatumVremeOdrzavanja, '" + duel.DatumVremeOdrzavanja.ToString("yyyy-MM-dd HH:mm") +
                "') = 0 AND KvizID = " + duel.Kviz.KvizID + "";

            rez = komunikacija.DuelUIstoVreme(duel) as List<Duel>;
            if (rez.Count != 0)
            {
                MessageBox.Show("Već postoji duel koji se održava u kvizu u ovo vreme!");
                return false;
            }
            object rezultat = komunikacija.ZapamtiDuel(duel);

            if (rezultat == null)
            {
                MessageBox.Show("Sistem ne može da zapamti duel!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio duel!");
                return true;
            }
        }

        internal void KreirajDuel(TextBox txtID, Button btnKreiraj, GroupBox gbDuel, GroupBox gbTim1, GroupBox gbTim2, ComboBox cmbTim1, ComboBox cmbTim2, Button btnSacuvaj, KreiranjeDuela kreiranjeDuela)
        {
            duel = komunikacija.KreirajDuel() as Duel;

            if (duel == null)
            {
                MessageBox.Show("Sistem ne može da kreira novi duel!");
                btnKreiraj.Enabled = true;
                gbDuel.Enabled = false;
                gbTim1.Enabled = false;
                gbTim2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Sistem je kreirao novi duel!");
                txtID.Text = duel.DuelID.ToString();
                btnKreiraj.Enabled = false;
                gbDuel.Enabled = true;
                btnSacuvaj.Enabled = true;
                gbTim1.Enabled = true;
                gbTim2.Enabled = true;
            }
        }

        internal void UcitajTimove(ComboBox cmbTim1, KreiranjeDuela forma)
        {
            List<Tim> lista = (List<Tim>)komunikacija.VratiSveTimove();
            //List<Tim> t = new List<Tim>(); za alternativni scenario kod preduslova
            if (lista.Count == 0)
            {
                MessageBox.Show("Sistem ne može da pronađe listu timova!");
                forma.Close();
                return;
            }
            else
            {
                cmbTim1.DataSource = lista;
                cmbTim1.SelectedItem = null;
                MessageBox.Show("Sistem je pronašao listu timova!");
            }
        }

        internal void DodajUcesce(DataGridView dgvTim, DataGridView dgvKviz, TextBox txtDatumUplate, TextBox txtIznos)
        {
            Ucesce ucesce = new Ucesce();
            try
            {
                ucesce.Tim = dgvTim.CurrentRow.DataBoundItem as Tim;
                ucesce.Kviz = dgvKviz.CurrentRow.DataBoundItem as Kviz;
            }
            catch (Exception)
            {
                MessageBox.Show("Niste odabrali kviz ili tim!");
                return;
            }
            try
            {
                ucesce.DatumUplate = DateTime.ParseExact(txtDatumUplate.Text, "dd.MM.yyyy", null);
            }
            catch (Exception)
            {
                MessageBox.Show("Datum mora biti u formatu dd.MM.yyyy!");
                return;
            }
            try
            {
                ucesce.Iznos = Convert.ToInt32(txtIznos.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nevalidan unos iznosa uplate!");
                return;
            }
            ucesce.USLOVI = " TimID = " + ucesce.Tim.TimID + " AND KvizID = " + ucesce.Kviz.KvizID + "";
            List<Ucesce> rez = komunikacija.ProveraUcesca(ucesce) as List<Ucesce>;
            if (rez.Count != 0)
            {
                MessageBox.Show("Već postoji učešće za odabrani tim u odabranom kvizu!");
                return;
            }

            foreach (Ucesce u in listaUcesca)
            {
                if (ucesce.Tim.TimID == u.Tim.TimID && ucesce.Kviz.KvizID == u.Kviz.KvizID)
                {
                    MessageBox.Show("Već ste uneli učešće odabrane timove za odabrani kviz!");
                    return;
                }
            }
            listaUcesca.Add(ucesce);
        }

        internal void SacuvajUcesca()
        {
            Tim t = new Tim();
            t.ListaUcescaTima = listaUcesca;

            object rezultat = komunikacija.ZapamtiUcesca(t);

            if (rezultat == null)
            {
                MessageBox.Show("Sistem ne može da zapamti nove uplate učešća!");
                return;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio nova učešća!");
                return;
            }
        }

        internal void ObrisiUcesce(DataGridView dgvUcesca)
        {
            try
            {
                ucesce = dgvUcesca.CurrentRow.DataBoundItem as Ucesce;
                listaUcesca.Remove(ucesce);
            }
            catch (Exception)
            {
                MessageBox.Show("Niste odabrali učešće koje želite da obrišete!");
                return;
            }
        }

        internal void PopuniUcesca(DataGridView dgvUcesca)
        {
            listaUcesca = new BindingList<Ucesce>();
            dgvUcesca.DataSource = listaUcesca;
        }

        internal void UcitajKvizove(DataGridView dgvKviz)
        {
            kviz = new Kviz();
            List<Kviz> lista = komunikacija.VratiSveKvizove() as List<Kviz>;
            dgvKviz.DataSource = lista;
        }

        internal void UcitajTimove(DataGridView dgvTim)
        {
            tim = new Tim();
            List<Tim> lista = komunikacija.VratiSveTimove() as List<Tim>;
            dgvTim.DataSource = lista;
        }

        internal void PrikaziDetalje(Tim tim, TextBox txtID, TextBox txtNaziv, DataGridView dgvClanovi, DetaljiOTimu detaljiOTimu)
        {
            txtID.Text = tim.TimID.ToString();
            txtNaziv.Text = tim.Naziv;

            List<Clan> clanovi = komunikacija.VratiSveClanove(tim) as List<Clan>;

            BindingList<Clan> izvor = new BindingList<Clan>(clanovi);
            dgvClanovi.DataSource = izvor;
            dgvClanovi.Columns[0].Visible = false;
            tim.Clanovi = izvor;
        }

        internal void IzmeniTim(Tim tim, TextBox txtID, TextBox txtNaziv, DetaljiOTimu forma)
        {
            tim.Naziv = txtNaziv.Text;
            if (tim.Naziv == "")
            {
                MessageBox.Show("Morate uneti naziv tima!");
                return;
            }

            bool uspesno = (bool)komunikacija.IzmeniTim(tim);
            if (uspesno == true)
            {
                MessageBox.Show("Sistem je zapamtio tim!");
            }
            else
            {
                MessageBox.Show("Sistem ne može da zapamti tim!");
                forma.Close();
                return;
            }
        }

        internal void ObrisiTim(DataGridView dgvTimovi)
        {
            try
            {
                Tim tim = dgvTimovi.CurrentRow.DataBoundItem as Tim;
                //tim = null;
                
                Ucesce u = new Ucesce();
                u.Tim = tim;
                u.USLOVI = " TimID = " + u.Tim.TimID;
                List<Ucesce> rez = komunikacija.ProveraUcesca(u) as List<Ucesce>;
                if (rez.Count != 0)
                {
                    MessageBox.Show("Ne mozete da obrisete ovaj tim zbog naplate ucesca!");
                } 
                else if (komunikacija.ObrisiTim(tim))
                {
                    MessageBox.Show("Tim je obrisan!");
                }
                else
                {
                    MessageBox.Show("Sistem ne može da obriše odabrani tim!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greška");
            }
        }

        internal void PretraziTimovePoKriterijumu(DataGridView dgvTimovi, TextBox txtKriterijum, PretragaTima forma)
        {
            tim = new Tim();
            tim.USLOVI = " NazivTima like '%" + txtKriterijum.Text + "%'";
            List<Tim> lista = komunikacija.PronadjiTimove(tim) as List<Tim>;
            dgvTimovi.DataSource = lista;

            if (lista.Count == 0)
            {
                MessageBox.Show("Sistem ne može da nađe timove po zadatoj vrednosti!");
                forma.Close();
                return;
            }
            MessageBox.Show("Sistem je našao timove po zadatoj vrednosti!");
        }

        internal bool PrikaziTim(DataGridView dgvTimovi)
        {
            try
            {
                tim = dgvTimovi.CurrentRow.DataBoundItem as Tim;
                tim = komunikacija.PrikaziTim(tim) as Tim;

                if (tim == null)
                {
                    MessageBox.Show("Sistem nije učitao tim!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je učitao tim!");
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Niste odabrali tim!");
                return false;
            }
        }

        internal void KreirajTim(TextBox txtID, Button btnKreirajTim, GroupBox gbPodaci, DataGridView dgvClanovi, Button btnZapamtiTim, KreiranjeTima kreiranjeTima)
        {
            
            tim = komunikacija.KreirajTim() as Tim;

            if (tim == null)
            {
                MessageBox.Show("Sistem ne može da kreira novi tim!");
                btnKreirajTim.Enabled = true;
                gbPodaci.Enabled = false;
            }
            else
            {
                MessageBox.Show("Sistem je kreirao novi tim!");
                txtID.Text = tim.TimID.ToString();
                btnKreirajTim.Enabled = false;
                gbPodaci.Enabled = true;
                dgvClanovi.DataSource = tim.Clanovi;
                dgvClanovi.Columns[0].Visible = false;
                btnZapamtiTim.Enabled = true;
            }
        }

        internal bool SacuvajTim(TextBox txtNaziv, DataGridView dgvClanovi)
        {
            try
            {
                tim.Naziv = txtNaziv.Text;
                if (tim.Naziv == "")
                {
                    MessageBox.Show("Nevalidan naziv tima!");
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nevalidan naziv tima!");
                return false;
            }

            if (tim.Clanovi.Count < 3 || tim.Clanovi.Count > 4)
            {
                MessageBox.Show("Tim može imati najmanje 3, a najviše 4 člana!");
                return false;
            }
            object rezultat = komunikacija.ZapamtiTim(tim);

            if (rezultat == null)
            {
                MessageBox.Show("Sistem ne može da zapamti tim!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio novi tim!");
                return true;
            }
        }

        internal void ObrisiClana(DataGridView dgvClanovi)
        {
            try
            {
                Clan clan = dgvClanovi.CurrentRow.DataBoundItem as Clan;
                tim.Clanovi.Remove(clan);
            }
            catch (Exception)
            {
                MessageBox.Show("Niste odabrali člana kojeg želite da obrišete!");
            }
        }

        internal bool IzmeniClana(Clan clan, TextBox txtRBR, TextBox txtJMBG, TextBox txtIme, TextBox txtPrezime, TextBox txtDatum)
        {
            tim.Clanovi.Remove(clan);
            Clan c = new Clan();
            try
            {
                c.RedBr = Convert.ToInt32(txtRBR.Text);
                foreach (Clan cl in tim.Clanovi)
                {
                    if (cl.RedBr == c.RedBr)
                    {
                        MessageBox.Show("Član sa unetim rednim brojem već postoji u timu!");
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nevalidan unos rednog broja!");
                return false;
            }
            try
            {
                c.Jmbg = txtJMBG.Text;
                foreach (Clan cl in tim.Clanovi)
                {
                    if (cl.Jmbg == c.Jmbg)
                    {
                        MessageBox.Show("Član sa unetim JMBG-om već postoji u timu!");
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nevalidan unos JMBG!");
                return false;
            }
            try
            {
                c.Ime = txtIme.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Nevalidan unos imena!");
                return false;
            }
            try
            {
                c.Prezime = txtPrezime.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Nevalidan unos prezimena!");
                return false;
            }
            try
            {
                c.DatumRodjenja = Convert.ToDateTime(txtDatum.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nevalidan unos datuma rođenja!");
                return false;
            }
            return true;
        }

        internal bool DodajClana(TextBox txtRBR, TextBox txtJMBG, TextBox txtIme, TextBox txtPrezime, TextBox txtDatum)
        {
            clan = new Clan();
            clan.TimID = tim.TimID;
            try
            {
                clan.RedBr = Convert.ToInt32(txtRBR.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nevalidan redni broj!");
                return false;
            }
            clan.Jmbg = txtJMBG.Text;
            if (clan.Jmbg == "")
            {
                MessageBox.Show("Niste uneli JMBG!");
                return false;
            }
            clan.Ime = txtIme.Text;
            if (clan.Ime == "")
            {
                MessageBox.Show("Niste uneli ime!");
                return false;
            }
            clan.Prezime = txtPrezime.Text;
            if (clan.Prezime == "")
            {
                MessageBox.Show("Niste uneli prezime!");
                return false;
            }
            try
            {
                clan.DatumRodjenja = Convert.ToDateTime(txtDatum.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nevalidan datum rođenja!");
                return false;
            }
            foreach (Clan c in tim.Clanovi)
            {
                if (c.RedBr == clan.RedBr)
                {
                    MessageBox.Show("Član sa unetim rednim brojem već postoji u timu!");
                    return false;
                }
                if (c.Jmbg == clan.Jmbg)
                {
                    MessageBox.Show("Član sa unetim JMBG već postoji u timu!");
                    return false;
                }
            }
            tim.Clanovi.Add(clan);
            return true;
        }

        public static string poveziSeNaServer()
        {
            komunikacija = new Komunikacija();
            if (komunikacija.poveziSeNaServer())
            {
                return "Klijent je povezan na server!";
            }
            else return "Klijent nije povezan na server!";
        }

        public static void odjaviSeSaServera()
        {
            try
            {
                komunikacija.kraj();
            }
            catch (Exception)
            { }
        }

        internal bool PrijaviSe(TextBox txtIme, TextBox txtSifra)
        {
            try
            {
                admin = new Administrator();
                admin.KorisnickoIme = txtIme.Text;
                admin.Sifra = txtSifra.Text;

                admin = komunikacija.prijaviSe(admin) as Administrator;

                if (admin == null)
                {
                    MessageBox.Show("Uneli ste neispravne podatke, pokušajte ponovo!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Uspešno ste prijavljeni na sistem!");
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Server nije pokrenut!");
                return false;
            }

        }

    }
}
