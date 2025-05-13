using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Gerente : Funcionario, AumentoSalario 
{
    private double bonificacao;

    public Gerente(string nome, int idade, double salarioBase, double bonifiacacao) : base(nome, idade, salarioBase)
    {
        this.bonificacao = bonifiacacao;
    }

    public override double CalcularSalario()
    {
        return salarioBase + bonificacao;
    }
    public void AumentarSalario(double porcentagem)
    {
        salarioBase = ((porcentagem / 100) * salarioBase) + salarioBase;
    }
}

