using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modele.Jucator;

namespace Modele.Echipa
{
    public class Echipa:InterfaceEchipa
    {
        int GoluriPrimite;
        int GoluriMarcate;
        int Victorii;
        int Infrangeri;

        /*se vor adauga campuri ulterior*/

        public int getGoluriPrimite { get { return GoluriPrimite; } }
        public int getGoluriMarcate { get { return GoluriMarcate; } }
        public int getVictorii { get { return Victorii; } }
        public int getInfrangeri { get { return Infrangeri; } }

        public Echipa(int goluri_primite, int goluri_marcate, int victorii, int infrangeri)
        {
            this.GoluriPrimite = goluri_primite;
            this.GoluriMarcate = goluri_marcate;
            this.Victorii = victorii;
            this.Infrangeri = infrangeri;
        }
     
    }
}
