using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Jucator
{
    public class RJucator
    {
        private static List<Modele.Jucator.Jucator> _jucator = new List<Modele.Jucator.Jucator>();

        public void ADD_Jucator(Modele.Jucator.Jucator jucator)
        {
            var new_jucator = _jucator.FirstOrDefault(nj => nj.Equals(jucator));
            if (new_jucator != null) throw new DuplicateWaitObjectException();

            _jucator.Add(new_jucator);
            Console.WriteLine("New match added");
        }

        public void DELETE_Jucator(Modele.Jucator.Jucator nume_jucator)
        {
            var del_jucator = _jucator.FirstOrDefault(dj => dj.Equals(nume_jucator));
            _jucator.Remove(del_jucator);
            Console.WriteLine("Player deleted");
        }

        public void UPDATE_Jucator()
        {
            /*Baza de Date*/
            Console.WriteLine("Update Succesfull");
        }
    }
}
