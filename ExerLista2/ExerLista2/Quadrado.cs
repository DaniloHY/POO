using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Quadrado : Area
{
    private double lado;

    public Quadrado(double lado)
    {
        this.lado = lado;
    }

    public double CalcularArea()
    {
        double area = lado * lado;
        return area;
    }

}

