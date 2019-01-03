using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modele.Jucator
{
    public class Jucator:InterfaceJucator
    {
        string Nume;
        int Varsta;
        string Pozitie;
        bool Titular;
        /*se vor adauga campuri ulterior*/

        public string getNume { get { return Nume; } }
        public int getVarsta { get { return Varsta; } }
        public string getPozitie { get { return Pozitie; } }
        public bool getTitular { get { return Titular; } }

        public Jucator(string nume, int varsta, string pozitie, bool titular)
        {
            this.Nume = nume;
            this.Varsta = varsta;
            this.Pozitie = pozitie;
            this.Titular = titular;
        }
    }
}
