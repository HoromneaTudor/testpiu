using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testpiu1
{
    class Program
    {
        static void Main(string[] args)
        {
            Oras[] orase=new Oras[4];
            int nrorase=0;
            Oras.IdUltimOras = nrorase;

            string optiune;
            do
            {
                Console.WriteLine("A - Adauga oras (citire date oras + adaugare in vector de obiecte)");
                Console.WriteLine("L – afisare date despre toate orasele (se va utiliza metoda ConversieLaSir)");
                Console.WriteLine("R – afisarea oraselor care apartin unei regiuni (regiunea va fi citita de la tastatura)");
                Console.WriteLine("D - afisarea distantelor dintre orase. Afisarea distantei maxime.");
                Console.WriteLine("X - Terminare program");
                optiune = Console.ReadLine();
                Console.Clear();
                switch(optiune.ToUpper())
                {
                    case "A":
                        Oras o = CitireDeLaTastatura();
                        orase[nrorase] = o;
                        nrorase++;
                        break;
                    case "L":
                        AfisareOrase(orase, nrorase);
                        break;
                    case "R":
                        AfisareOraseAceeasiReg(orase,nrorase);
                        break;
                    case "D":
                        Oras o1 = CitireDeLaTastatura();
                        Oras o2 = CitireDeLaTastatura();
                        Distanta(o1, o2);
                        break;
                    default:
                        Console.WriteLine("optiune inexistenta! ");
                        break;

                }
            } while (optiune.ToUpper() != "X");

        }

        public static Oras CitireDeLaTastatura()
        {
            Console.WriteLine("introduceti coordonata x: ");
            string x_temp = Console.ReadLine();
            int x = Int32.Parse(x_temp);
            Console.WriteLine("introduceti coordonata y: ");
            string y_temp = Console.ReadLine();
            int y = Int32.Parse(y_temp);

            Oras o = new Oras(x, y);
            Console.WriteLine("introduceti regiunea :\n1-Moldova\n2-Transilvania\n3-Muntenia\n4-Dobrogea");
            o.Regiune = (Oras.RegiuneOras)Int32.Parse(Console.ReadLine());
            Console.Clear();
            
            return o;

        }
        public static void Distanta(Oras o1,Oras o2)
        {
            double dist;
            dist = Math.Sqrt((o1.x - o2.x) * (o1.x - o2.x) + (o1.y - o2.y) * (o1.y - o2.y));
            Console.WriteLine("distanta dintre orasele alese este de: {0}", dist);
        }
        public static void AfisareOrase(Oras[] orase,int nrorase)
        {
            Console.WriteLine("Orasele sunt:");
            for(int i=0;i<nrorase;++i)
            {
                Console.WriteLine(orase[i].conversieLaSir());
            }
        }
        public static void AfisareOraseAceeasiReg(Oras[] orase,int nrorase)
        {
            Oras o = new Oras();
            Console.WriteLine("introduceti regiunea dorita:\n1-Moldova\n2-Transilvania\n3-Muntenia\n4-Dobrogea");
            o.Regiune = (Oras.RegiuneOras)Int32.Parse(Console.ReadLine());
            for (int i = 0; i < nrorase; ++i)
            {
                if(string.Equals(orase[i].Regiune,o.Regiune))
                    Console.WriteLine(orase[i].conversieLaSir());

            }


        }
    }
}
