using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MemoriaRAM : Componente
{
    public int Capacidade { get; set; } // em MB

    public MemoriaRAM(int capacidade, DateTime dataFabricacao) : base(dataFabricacao)
    {
        Capacidade = capacidade;
    }
}