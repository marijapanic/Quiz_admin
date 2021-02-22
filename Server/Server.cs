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

namespace Server
{
    public class Server
    {
        Socket soket;
        Thread nit;
        public static List<NetworkStream> klijenti = new List<NetworkStream>();

        public bool pokreniServer()
        {
            try
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, 10000);
                soket.Bind(ep);

                ThreadStart nitDelegat = osluskujKlijente;
                nit = new Thread(nitDelegat);
                nit.IsBackground = true;
                nit.Start();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        void osluskujKlijente()
        {
            try
            {
                while (true)
                {
                    soket.Listen(5);
                    Socket klijent = soket.Accept();
                    NetworkStream tok = new NetworkStream(klijent);
                    new Obrada(tok);
                    klijenti.Add(tok);
                }
            }
            catch (Exception)
            {
            }
        }

        internal bool zaustaviServer()
        {
            try
            {
                soket.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
