using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celloveszetCLI
{
    internal class cellovo
    {
        public string nev {  get; private set; }
        public int elsoloves { get; private set; }
        public int masodikloves  { get; private set; }
        public int harmadikloves { get; private set; }
        public int negyedikloves { get; private set; }
        public cellovo(string sor)
        {
            string[] adat = sor.Split(";");
            nev = adat[0];
            elsoloves = int.Parse(adat[1]);
            masodikloves = int.Parse(adat[2]);
            harmadikloves = int.Parse(adat[3]);
            negyedikloves = int.Parse(adat[4]);
        }
    }
}
