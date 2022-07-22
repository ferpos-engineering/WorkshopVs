using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelepassBackend
{
    public class Database
    {
        private List<int> codici;

        public Database()
        {
            this.codici = new List<int>();

            this.codici.Add(1);
            this.codici.Add(2);
            this.codici.Add(3);
            this.codici.Add(45);
        }
        public bool Controlla(int codice)
        {
            foreach (int c in this.codici)
            {
                if (codice == c)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
