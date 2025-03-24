using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Funcionario
{
    private string nome;
    private string sobrenome;
    private double salarioMensal;

    public Funcionario(string nome, string sobrenome, double salarioMensal) 
    { 
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.salarioMensal = salarioMensal > 0 ? salarioMensal : 0;
    }

    public void ImprimirSalario()
    {
        Console.WriteLine($"O funcinário {nome} {sobrenome} tem um salário mensal de {salarioMensal}");
    }    
}

