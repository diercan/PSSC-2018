using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Meci
{
    public class RMeci
    {
        private static List<Modele.Meci.Meci> _meci = new List<Modele.Meci.Meci>();

        public void ADD_Meci(Modele.Meci.Meci meci)
        {
            var new_meci = _meci.FirstOrDefault(nm => nm.Equals(meci));
            if (new_meci != null) throw new DuplicateWaitObjectException();

            _meci.Add(meci);
            Console.WriteLine("New match added");
        }

        public void DELETE_Meci(Modele.Meci.Meci nume_meci)
        {
            var del_meci = _meci.FirstOrDefault(dm => dm.Equals(nume_meci));
            _meci.Remove(del_meci);
            Console.WriteLine("Match deleted");
        }

        public void UPDATE_Meci()
        { 
            /*Baza de Date*/
            Console.WriteLine("Update Succesfull");
        }
    }
}
