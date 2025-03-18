using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Carro : Veiculo
{
    int potenciaMotor;
    int qtdPortas;


    public int PotenciaMotor { 
        get
        {
            return potenciaMotor;
        }
    }

    public Carro(int potenciaMotor, int qtdRodas, string cor, string marca, double velocidade) : base(qtdRodas,cor,marca,velocidade)
    {
        this.potenciaMotor = potenciaMotor;
    }
}

