using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegozioBicicletteBackEnd.DataModel
{
    public class Batteria
    {
        private float capMax;
        private byte statoCarica;
        private List<Ruota> ruota;

        public void Scarica (float quantità)
        {
            throw new NotImplementedException();
        }
    }
}
