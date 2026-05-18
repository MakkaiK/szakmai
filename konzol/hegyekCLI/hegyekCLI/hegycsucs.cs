using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hegyekCLI
{
    public class hegycsucs
    {
        public string nev {  get; private set; }
        public string hegyseg { get; private set; }
        public int magassag { get; private set; }

        public hegycsucs(string sor)
        {
            string[] adatok = sor.Split(";");
            nev = adatok[0];
            hegyseg = adatok[1];
            magassag = int.Parse(adatok[2]);
        }
    }
}
