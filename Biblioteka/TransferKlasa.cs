using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public enum Operacije
    {
        KRAJ = 1,
        PRIJAVISE = 2,
        KREIRAJNOVITIM = 3,
        ZAPAMTITIM = 4,
        UCITAJTIMOVE = 5,
        PRONADJITIMOVE = 6,
        UCITAJCLANOVE = 7,
        OBRISITIM = 8,
        IZMENITIM = 9,
        UCITAJKVIZOVE = 10,
        PRONADJIUCESCE = 11,
        ZAPAMTIUCESCA = 12,
        KREIRAJNOVIDUEL = 13,
        PRONADJIDUELUSLOV = 14,
        ZAPAMTIDUEL = 15,
        UCITAJDUELE = 16,
        PRONADJIDUELE = 17,
        PRIKAZIDUEL = 18,
        PRIKAZITIM = 19
    }
    [Serializable]
    public class TransferKlasa
    {
        public Operacije Operacija;
        public Object transferObjekat;
        public Object rezultat;
    }
}
