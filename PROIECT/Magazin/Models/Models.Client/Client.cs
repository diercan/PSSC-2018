using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Client
{
    public class Client:InterfaceClient
    {
        string Nume;
        string Prenume;
        int Varsta;
        string Adresa;
        int Suma_cheltuita;

        public string getNume { get { return Nume; } }
        public string getPrenume { get { return Prenume; } }
        public int getVarsta { get { return Varsta; } }
        public string getAdresa { get { return Adresa; } }
        public int getSuma_cheltuita { get { return Suma_cheltuita; } }

        public Client(string nume, string prenume, int varsta, string adresa, int suma_cheltuita)
        {

            this.Nume = nume;
            this.Prenume = prenume;
            this.Varsta = varsta;
            this.Adresa = adresa;
            this.Suma_cheltuita = suma_cheltuita;

        }
    }
}
