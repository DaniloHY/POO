using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Retangulo
{
    private double altura;
    private double largura;

    public Retangulo(double altura, double largura)
    {
        this.altura = altura;
        this.largura = largura;
    }

    public double Area()
    {
        double area = altura * largura;
        return area;
    }  
    
    public double Perimetro()
    {
        double perimetro = (altura * 2) + (largura * 2);
        return perimetro;
    }


}

