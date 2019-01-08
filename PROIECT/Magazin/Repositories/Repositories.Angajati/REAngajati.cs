using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Angajati
{
    public class REAngajati
    {
        private static List<Models.Vanzator.Vanzator> _vanzator = new List<Models.Vanzator.Vanzator>();

        public void ADD_Vanzator(Models.Vanzator.Vanzator vanzator)
        {
            var new_vanzator = _vanzator.FirstOrDefault(ne => ne.Equals(vanzator));
            if (new_vanzator != null) throw new DuplicateWaitObjectException();
            _vanzator.Add(new_vanzator);
            Console.WriteLine("New vanzator added");
        }

        public void DELETE_Vanzator(Models.Vanzator.Vanzator vanzator)
        {
            var del_vanzator = _vanzator.FirstOrDefault(de => de.Equals(vanzator));
            _vanzator.Remove(del_vanzator);
            Console.WriteLine("Vanzator deleted");
        }

        public void UPDATE_Vanzator()
        {
            /*Baza de Date*/
            Console.WriteLine("Update Succesfull");
        }
    }
}
