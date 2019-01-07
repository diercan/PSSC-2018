using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Produs
{
    public class Produs:InterfaceProdus
    {
        int Pret;
        int Cantitate;
        string Categorie;
        string Data_productiei;

        public int getPret { get { return Pret; } }
        public int getCantitate { get { return Cantitate; } }
        public string getCategorie { get { return Categorie; } }
        public string Data_productie { get { return Data_productie; } }

        public Produs(int pret, int cantitate, string categorie, string data_productiei)
        {
            this.Pret = pret;
            this.Cantitate = cantitate;
            this.Categorie = categorie;
            this.Data_productiei = data_productiei;
        }
    }
}
