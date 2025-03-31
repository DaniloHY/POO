using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FonteAlimentacao : Componente
{
    public int Potencia { get; set; } // em Watts

    public FonteAlimentacao(int potencia, DateTime dataFabricacao) : base(dataFabricacao)
    {
        Potencia = potencia;
    }
}
