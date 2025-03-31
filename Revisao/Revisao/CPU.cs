using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CPU : Componente
{
    public int Nucleos { get; set; }
    public double Clock { get; set; }

    public CPU(int nucleos, double clock, DateTime dataFabricacao) : base(dataFabricacao)
    {
        Nucleos = nucleos;
        Clock = clock;
    }
}