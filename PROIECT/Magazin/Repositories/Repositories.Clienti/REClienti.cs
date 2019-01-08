using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Clienti
{
    public class REClienti
    {
        private static List<Models.Client.Client> _client = new List<Models.Client.Client>();

        public void ADD_Client(Models.Client.Client client)
        {
            var new_client = _client.FirstOrDefault(ne => ne.Equals(client));
            if (new_client != null) throw new DuplicateWaitObjectException();
            _client.Add(new_client);
            Console.WriteLine("New client added");
        }

        public void DELETE_Client(Models.Client.Client client)
        {
            var del_client = _client.FirstOrDefault(de => de.Equals(client));
            _client.Remove(del_client);
            Console.WriteLine("Vanzator deleted");
        }

        public void UPDATE_Client()
        {
            /*Baza de Date*/
            Console.WriteLine("Update Succesfull");
        }
    }
}
