using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PlacaVideo : Componente
{
    public int Memoria { get; set; } // em MB

    public PlacaVideo(int memoria, DateTime dataFabricacao) : base(dataFabricacao)
    {
        Memoria = memoria;
    }
}
