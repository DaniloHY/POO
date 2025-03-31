using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HD : Componente
{
    public int Capacidade { get; set; } // em GB
    public double TempoEscrita { get; set; }

    public HD(int capacidade, double tempoEscrita, DateTime dataFabricacao) : base(dataFabricacao)
    {
        Capacidade = capacidade;
        TempoEscrita = tempoEscrita;
    }
}