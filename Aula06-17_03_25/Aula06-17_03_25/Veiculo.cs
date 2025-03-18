using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Veiculo
{
    int qtdRodas;
    string cor;
    string marca;
    protected double velocidade;

    public Veiculo(int qtdRodas, string cor, string marca, double velocidade)
    {
        this.qtdRodas = qtdRodas;
        this.cor = cor;
        this.marca = marca;
        this.velocidade = velocidade;
    }

    public double Velocidade
    {
        get
        {
            return velocidade;
        }
    }    
    public void Acelerar(double velocidade)
    {
        this.velocidade += velocidade;
    } 

}

