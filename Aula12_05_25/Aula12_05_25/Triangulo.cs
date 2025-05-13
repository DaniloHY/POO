using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Triangulo : FiguraGeometrica
{
    double lado1;
    double lado2;
    double lado3;

    public Triangulo(double lado1, double lado2, double lado3) 
    {
        this.lado1 = lado1;
        this.lado2 = lado2;
        this.lado3 = lado3;
    }

    public override double CalcularArea()
    {
        double s = (lado1 + lado2 + lado3) / 2;

        return Math.Sqrt((s * (s - lado1) * (s - lado2) * (s - lado3)));
    }

    public override double CalcularPerimetro()
    {
        return lado1 + lado2 + lado3;
    }

}

