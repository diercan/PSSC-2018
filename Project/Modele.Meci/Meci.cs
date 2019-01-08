using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modele.Echipa;

namespace Modele.Meci
{
    public class Meci:InterfaceMeci
    {
        public int ScoreHome { get; set; }
        public int ScoreGuest { get; set; }

        /*se vor adauga campuri ulterior*/

     /*   public string getScor { get { return Scor; } }
        public string getVartonase { get { return Cartonase; } }

        public Meci(string scor, string cartonase)
        {
            this.Scor = scor;
            this.Cartonase = cartonase;
        }*/
    }
}
