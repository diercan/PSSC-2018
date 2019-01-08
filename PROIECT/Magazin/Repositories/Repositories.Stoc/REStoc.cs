using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Stoc
{
   public class REStoc
    {

        private static List<Models.Produs.Produs> _produs = new List<Models.Produs.Produs>();

        public void ADD_Produs(Models.Produs.Produs produs)
        {
            var new_produs = _produs.FirstOrDefault(ne => ne.Equals(produs));
            if (new_produs != null) throw new DuplicateWaitObjectException();
            _produs.Add(new_produs);
            Console.WriteLine("New produs added");
        }

        public void DELETE_Produs(Models.Produs.Produs produs)
        {
            var del_client = _produs.FirstOrDefault(de => de.Equals(produs));
            _produs.Remove(del_client);
            Console.WriteLine("Produs deleted");
        }

        public void UPDATE_Produs()
        {
            /*Baza de Date*/
            Console.WriteLine("Update Succesfull");
        }
    }
}
