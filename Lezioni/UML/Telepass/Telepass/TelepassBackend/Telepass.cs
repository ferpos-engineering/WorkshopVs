using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelepassBackend
{
    public class Telepass
    {
        protected int codice;

        public Telepass(int codice)
        {
            this.codice = codice;
        }

        public int Codice
        {
            get
            {
                return this.codice;
            }

            set
            {
                this.codice = value; 
            }
        }
    }
}
