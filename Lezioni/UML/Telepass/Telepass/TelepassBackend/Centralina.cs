using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelepassBackend
{
    public class Centralina
    {
        private Database database;

        public Centralina(Database database)
        {
            this.database = database;
        }         
        
        public void Run(Telepass telepass)
        {
            int codice = telepass.Codice;

            bool outcome = this.database.Controlla(codice);
        }
    }
}
