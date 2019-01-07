using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Vanzator
{
    public class Vanzator : InterfaceVanzator
    {
        string Nume;
        string Prenume;
        string Functie_departament;
        int Salariu;
        int Vanzari;

        public string getNume { get { return Nume; } }
        public string getPrenume { get { return Prenume; } }
        public string getFunctie_departament { get { return Functie_departament; } }
        public int getSalariu { get { return Salariu; } }
        public int getVanzari { get { return Vanzari; } }

        public Vanzator(string nume, string prenume, string functie_departament, int salariu, int vanzari)
        {
            this.Nume = nume;
            this.Prenume = prenume;
            this.Functie_departament = functie_departament;
            this.Salariu = salariu;
            this.Vanzari = vanzari;
        }
    }
}