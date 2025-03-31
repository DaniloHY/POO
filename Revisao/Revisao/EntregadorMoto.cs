using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EntregadorMoto : Entregador
{
    public override bool PodeEntregar(double distancia) => distancia >= 5;
}
