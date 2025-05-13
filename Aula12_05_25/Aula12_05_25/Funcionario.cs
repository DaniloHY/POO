using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Funcionario
{
    private string nome;
    private int idade;
    protected double salarioBase;
    public Funcionario(string nome, int idade, double salarioBase)
    {
        this.nome = nome;
        this.idade = idade;
        this.salarioBase = salarioBase;
    }
    public abstract double CalcularSalario();
}

