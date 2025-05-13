using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Circulo : FiguraGeometrica
{
    double raio;

    public Circulo(double raio)
    {
        this.raio = raio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(raio,2);
    }

    public override double CalcularPerimetro()
    {
       return 2 * Math.PI * raio;
    }
}

