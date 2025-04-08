using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingMe
{
    public class Carta
    {
        private TipoCarta tipoCarta;

        public TipoCarta TipoCarta { get { return tipoCarta; } }

        public Carta(TipoCarta tipoCarta)
        {
            this.tipoCarta = tipoCarta;
        }
    }
}
