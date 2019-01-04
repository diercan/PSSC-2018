using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Echipa
{
    public class REchipa
    {
        private static List<Modele.Echipa.Echipa> _echipa = new List<Modele.Echipa.Echipa>();

        public void ADD_Echipa(Modele.Echipa.Echipa echipa)
        {
            var new_echipa = _echipa.FirstOrDefault(ne => ne.Equals(echipa));
            if (new_echipa != null) throw new DuplicateWaitObjectException();
            _echipa.Add(new_echipa);
            Console.WriteLine("New team added");
        }

        public void DELETE_Echipa(Modele.Echipa.Echipa echipa)
        {
            var del_echipa = _echipa.FirstOrDefault(de => de.Equals(echipa));
            _echipa.Remove(del_echipa);
            Console.WriteLine("Team deleted");
        }

        public void UPDATE_Echipa()
        {
            /*Baza de Date*/
            Console.WriteLine("Update Succesfull");
        }
    }
}
