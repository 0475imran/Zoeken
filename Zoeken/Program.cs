using System.Diagnostics;

namespace Zoeken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] getallen = new int[10000];

            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = random.Next(1, 100000);
            }

            Array.Sort(getallen);

            int zoekGetal = getallen[5000];

            Console.WriteLine("ZoekGetal: " + zoekGetal);

            Stopwatch stopwatch = Stopwatch.StartNew();

            int gevonden = -1;

            for (int i = 0; i < getallen.Length; i++)
            {
                if (getallen[i] == zoekGetal)
                {
                    gevonden = i;
                    break;
                }

            }

            stopwatch.Stop();

            Console.WriteLine("Tijd: " + stopwatch.ElapsedTicks + " ticks");

            Console.WriteLine("Gevonden op positie: " + gevonden);

            Stopwatch stopwatchBinair = Stopwatch.StartNew();

            int links = 0;
            int rechts = getallen.Length - 1;
            int gevondenBinaire = -1;

            while (links <= rechts)
            {
                int midden = (links + rechts) / 2;

                if (getallen[midden] == zoekGetal)
                {
                    gevondenBinaire = midden;
                    break;
                }
                else if (zoekGetal < getallen[midden])
                {
                    rechts = midden - 1;
                }
                else
                {
                    links = midden + 1;
                }
                }

            stopwatchBinair.Stop();

            Console.WriteLine("Binaire zoekopdracht gevonden op positie: " + gevondenBinaire);
            Console.WriteLine("Binaire tijd: " + stopwatchBinair.ElapsedTicks + " ticks");
            Console.WriteLine("Lineair zoeken: " + stopwatch.ElapsedTicks + " ticks");



            }
        }
    }


