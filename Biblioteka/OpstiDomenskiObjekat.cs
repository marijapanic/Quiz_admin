using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public interface OpstiDomenskiObjekat
    {
        OpstiDomenskiObjekat citajRedTabele(DataRow red);

        string ObjekatID { get; }
        string NazivTabele { get; }
        string UslovID { get; }
        string OpstiUslov { get; }
        string UpitZaInsert { get; }
        string UpitZaUpdate { get; }
    }
}
