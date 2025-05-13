using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Quadrado : FiguraGeometrica
{
    double lado;

    public Quadrado(double lado)
    {
        this.lado = lado;
    }

    public override double CalcularArea()
    {
        return lado * lado;
    }

    public override double CalcularPerimetro()
    {
        return lado * 4;
    }
}

