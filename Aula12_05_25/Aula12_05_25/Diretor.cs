using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Diretor : Funcionario, AumentoSalario
{
    string nome;
    int idade;
    double salarioBase;
    double lucroEmpresa;

    public Diretor(string nome, int idade, double salarioBase, double lucroEmpresa) : base(nome, idade, salarioBase)
    {
        this.lucroEmpresa = lucroEmpresa;
    }

    public override double CalcularSalario()
    {
        return salarioBase + lucroEmpresa;
    }

    public void AumentarSalario(double porcentagem)
    {
        salarioBase = ((porcentagem / 100) * salarioBase) + salarioBase;
    }

}

