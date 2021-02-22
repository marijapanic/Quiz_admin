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
using Sesija;
using Server.SO;

namespace Server
{
    class Obrada
    {
        private NetworkStream tok;
        BinaryFormatter formater;

        public Obrada(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart ts = obradiKlijenta;
            Thread nit = new Thread(ts);
            nit.Start();
        }

        void obradiKlijenta()
        {
            int operacija = 0;
            while (operacija != (int)Operacije.KRAJ)
            {
                TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;

                switch (transfer.Operacija)
                {

                    case Operacije.KRAJ:
                        operacija = 1;
                        break;
                    case Operacije.PRIJAVISE:
                        PrijaviSe pr = new PrijaviSe();
                        transfer.rezultat = pr.IzvrsiSO(transfer.transferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.IZMENITIM:
                        IzmeniTim it = new IzmeniTim();
                        transfer.rezultat = it.IzvrsiSO(transfer.transferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.KREIRAJNOVITIM:
                        KreirajNoviTim knt = new KreirajNoviTim();
                        transfer.rezultat = knt.IzvrsiSO(transfer.transferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.KREIRAJNOVIDUEL:
                        KreirajNoviDuel knd = new KreirajNoviDuel();
                        transfer.rezultat = knd.IzvrsiSO(transfer.transferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.OBRISITIM:
                        ObrisiTim ot = new ObrisiTim();
                        transfer.rezultat = ot.IzvrsiSO(transfer.transferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.PRIKAZIDUEL:
                        PrikaziDuel pd = new PrikaziDuel();
                        transfer.rezultat = pd.IzvrsiSO(transfer.transferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.PRIKAZITIM:
                        PrikaziTim pt = new PrikaziTim();
                        transfer.rezultat = pt.IzvrsiSO(transfer.transferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.PRONADJITIMOVE:
                        NadjiTimove nt = new NadjiTimove();
                        transfer.rezultat = nt.IzvrsiSO(transfer.transferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.PRONADJIUCESCE:
                        NadjiUcesce nu = new NadjiUcesce();
                        transfer.rezultat = nu.IzvrsiSO(transfer.transferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.PRONADJIDUELUSLOV:
                        ProveraOdrzavanjaDuela pod = new ProveraOdrzavanjaDuela();
                        transfer.rezultat = pod.IzvrsiSO(transfer.transferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.PRONADJIDUELE:
                        NadjiDuele nd = new NadjiDuele();
                        transfer.rezultat = nd.IzvrsiSO(transfer.transferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.UCITAJCLANOVE:
                        UcitajClanove uc = new UcitajClanove();
                        transfer.rezultat = uc.IzvrsiSO(transfer.transferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.UCITAJDUELE:
                        UcitajDuele ud = new UcitajDuele();
                        transfer.rezultat = ud.IzvrsiSO(transfer.transferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.UCITAJKVIZOVE:
                        UcitajKvizove uk = new UcitajKvizove();
                        transfer.rezultat = uk.IzvrsiSO(transfer.transferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.UCITAJTIMOVE:
                        UcitajTimove ut = new UcitajTimove();
                        transfer.rezultat = ut.IzvrsiSO(transfer.transferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.ZAPAMTIDUEL:
                        ZapamtiDuel zd = new ZapamtiDuel();
                        transfer.rezultat = zd.IzvrsiSO(transfer.transferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.ZAPAMTITIM:
                        ZapamtiTim zt = new ZapamtiTim();
                        transfer.rezultat = zt.IzvrsiSO(transfer.transferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.ZAPAMTIUCESCA:
                        ZapamtiUcesca zu = new ZapamtiUcesca();
                        transfer.rezultat = zu.IzvrsiSO(transfer.transferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
