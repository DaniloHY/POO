using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Circulo : Area
{
    private double pi = 3.14;
    private double raio;

    public Circulo(double raio)
    {
        this.raio = raio;
    }

    public double CalcularArea()
    {
        return pi * (raio * raio);
    }
}

