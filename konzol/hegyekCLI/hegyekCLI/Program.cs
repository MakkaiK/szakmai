namespace hegyekCLI
{
    public class Program
    {
        public static bool tartalmaz(string keresett, string nev, string hegyseg)
        {
            if(nev.Contains(keresett) || hegyseg.Contains(keresett))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            List<hegycsucs> hegyek = new List<hegycsucs>();
            var sorok = File.ReadAllLines("hegyek.csv").Skip(1);
            foreach (var sor in sorok)
            {
                hegyek.Add(new hegycsucs(sor));
            }

            foreach (var hegy in hegyek)
            {
                if (hegy.magassag > 950)
                {
                    Console.WriteLine($"{hegy.nev} {hegy.hegyseg} {hegy.magassag}");
                }
            }

            Console.WriteLine("Kérem a keresett szüt:");
            string keresett = Console.ReadLine();
            Console.WriteLine("........");
            foreach (var hegy in hegyek)
            {
                if (tartalmaz(keresett, hegy.nev, hegy.hegyseg))
                {
                    Console.WriteLine(hegy.nev);
                }
            }
        }
    }
}
