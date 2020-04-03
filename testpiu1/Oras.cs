using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testpiu1
{
    class Oras
    {
        public int x { get; set; }
        public int y { get; set; }
        public int IdOras { get; set; }
        public static int IdUltimOras { get; set; } = 0;
        public enum RegiuneOras
        {
            Moldova=1,
            Transilvania=2,
            Muntenia=3,
            Dobrogea=4,

        }
        public RegiuneOras Regiune { get; set; }

        public Oras()
        {
            x = 0;
            y = 0;


        }
        public Oras(int xx,int yy)
        {
            x = xx;
            y = yy;


        }
        public string conversieLaSir()
        {
            string s = string.Format("Orasul are coordonatele x: {0} ,y: {1} si este din regiunea: {2}", x, y, Regiune);
            return s;
        }

    }
}
