using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteka;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Klijent
{
    public class Komunikacija
    {
        TcpClient klijent;
        NetworkStream tok;
        BinaryFormatter formater;

        public bool poveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("127.0.0.1", 10000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        internal object VratiSveDuele()
        {
            //prijem
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UCITAJDUELE;
            transfer.transferObjekat = new Duel();
            formater.Serialize(tok, transfer);

            //slanje
            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.rezultat;
        }

        internal object VratiSveTimove()
        {
            //prijem            
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UCITAJTIMOVE;
            transfer.transferObjekat = new Tim();
            formater.Serialize(tok, transfer);

            //slanje
            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.rezultat;
        }

        internal object PrikaziDuel(Duel duel)
        {
            //prijem
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PRIKAZIDUEL;
            transfer.transferObjekat = duel;
            formater.Serialize(tok, transfer);

            //slanje
            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.rezultat;
        }

        internal object VratiSveKvizove()
        {
            //prijem            
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UCITAJKVIZOVE;
            transfer.transferObjekat = new Kviz();
            formater.Serialize(tok, transfer);

            //slanje
            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.rezultat;
        }

        internal object VratiSveClanove(Tim tim)
        {
            //prijem            
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UCITAJCLANOVE;
            transfer.transferObjekat = tim;
            formater.Serialize(tok, transfer);

            //slanje
            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.rezultat;
        }

        internal object KreirajDuel()
        {
            //prijem
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KREIRAJNOVIDUEL;
            transfer.transferObjekat = new Duel();
            formater.Serialize(tok, transfer);

            //slanje
            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.rezultat;
        }

        internal object PronadjiDuele(Duel duel)
        {
            //prijem            
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PRONADJIDUELE;
            transfer.transferObjekat = duel;
            formater.Serialize(tok, transfer);

            //slanje
            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.rezultat;
        }

        internal object ProveraUcesca(Ucesce ucesce)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PRONADJIUCESCE;
            transfer.transferObjekat = ucesce;
            formater.Serialize(tok, transfer);

            //slanje
            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.rezultat;
        }

        internal bool ObrisiTim(Tim tim)
        {
            //prijem
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.OBRISITIM;
            transfer.transferObjekat = tim;
            formater.Serialize(tok, transfer);

            //slanje
            transfer = formater.Deserialize(tok) as TransferKlasa;
            return (bool)transfer.rezultat;
        }

        internal object ZapamtiUcesca(Tim t)
        {
            //prijem
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZAPAMTIUCESCA;
            transfer.transferObjekat = t;
            formater.Serialize(tok, transfer);

            //slanje
            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.rezultat;
        }

        internal object IzmeniTim(Tim tim)
        {
            //prijem
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.IZMENITIM;
            transfer.transferObjekat = tim;
            formater.Serialize(tok, transfer);

            //prijem
            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.rezultat;
        }

        internal object DuelUIstoVreme(Duel duel)
        {
            //prijem
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PRONADJIDUELUSLOV;
            transfer.transferObjekat = duel;
            formater.Serialize(tok, transfer);

            //slanje
            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.rezultat;
        }

        internal object PronadjiTimove(Tim tim)
        {
            //prijem            
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PRONADJITIMOVE;
            transfer.transferObjekat = tim;
            formater.Serialize(tok, transfer);

            //slanje
            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.rezultat;
        }

        internal object ZapamtiDuel(Duel duel)
        {
            //prijem
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZAPAMTIDUEL;
            transfer.transferObjekat = duel;
            formater.Serialize(tok, transfer);

            //slanje
            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.rezultat;
        }

        internal object KreirajTim()
        {
            //prijem
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KREIRAJNOVITIM;
            transfer.transferObjekat = new Tim();
            formater.Serialize(tok, transfer);

            //slanje
            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.rezultat;
        }

        public void kraj()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KRAJ;
            formater.Serialize(tok, transfer);
        }

        public object prijaviSe(Administrator admin)
        {
            //prijem
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PRIJAVISE;
            transfer.transferObjekat = admin;
            formater.Serialize(tok, transfer);

            //slanje
            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.rezultat;
        }

        internal object ZapamtiTim(Tim tim)
        {
            //prijem
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZAPAMTITIM;
            transfer.transferObjekat = tim;
            formater.Serialize(tok, transfer);

            //slanje
            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.rezultat;
        }

        internal object PrikaziTim(Tim tim)
        {
            //prijem
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PRIKAZITIM;
            transfer.transferObjekat = tim;
            formater.Serialize(tok, transfer);

            //slanje
            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.rezultat;
        }
    }
}
