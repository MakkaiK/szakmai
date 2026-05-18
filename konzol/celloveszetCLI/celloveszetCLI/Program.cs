namespace celloveszetCLI
{
    internal class Program
    {
        public static int legnagyobb(int elsoloves, int masodikloves, int harmadikloves, int negyedikloves)
        {
            int legnagyobb = elsoloves;
            if (legnagyobb < masodikloves)
            {
                legnagyobb = masodikloves;
            }
            if (legnagyobb < harmadikloves)
            {
                legnagyobb = harmadikloves;
            }
            if (legnagyobb < negyedikloves)
            {
                legnagyobb = negyedikloves;
            }
            return legnagyobb;
        }
        static void Main(string[] args)
        {
            List<cellovo> lovesek = new List<cellovo>();
            foreach (var sor in File.ReadLines("lovesek.csv"))
            {
                lovesek.Add(new cellovo(sor));
            }

            foreach (var cellovo in lovesek)
            {
                Console.WriteLine(cellovo.nev + " " + legnagyobb(cellovo.elsoloves, cellovo.masodikloves, cellovo.harmadikloves, cellovo.negyedikloves));
            }

            cellovo legtobbPont = lovesek[0];
            foreach (var cellovo in lovesek)
            {
                if (legnagyobb(legtobbPont.elsoloves, legtobbPont.masodikloves, legtobbPont.harmadikloves, legtobbPont.negyedikloves) < legnagyobb(cellovo.elsoloves, cellovo.masodikloves, cellovo.harmadikloves, cellovo.negyedikloves))
                {
                    legtobbPont = cellovo;
                }
            }
            Console.WriteLine("A legnagyobb találatot lövő eredményei:");
            Console.WriteLine(legtobbPont.nev + " " + legtobbPont.elsoloves + " " + legtobbPont.masodikloves + " " + legtobbPont.harmadikloves + " " + legtobbPont.negyedikloves);

            cellovo leggyengebb = lovesek[0];
            foreach (var cellovo in lovesek)
            {
                if ((leggyengebb.elsoloves + leggyengebb.masodikloves + leggyengebb.harmadikloves + leggyengebb.negyedikloves)/4 > (cellovo.elsoloves + cellovo.masodikloves + cellovo.harmadikloves + cellovo.negyedikloves) / 4)
                {
                    leggyengebb = cellovo;
                }
            }
            Console.WriteLine("A leggyengebbatlagu találatot lövő eredményei:");
            Console.WriteLine(leggyengebb.nev + " " + (leggyengebb.elsoloves + leggyengebb.masodikloves + leggyengebb.harmadikloves + leggyengebb.negyedikloves) / 4);
        }
    }
}
