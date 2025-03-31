using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Triangulo : Area
{
    private double bases;
    private double altura;

    public Triangulo(double bases, double altura)
    {
        this.bases = bases;
        this.altura = altura;
    }

    public double CalcularArea()
    {
        return (bases * altura) / 2;
    }
}
