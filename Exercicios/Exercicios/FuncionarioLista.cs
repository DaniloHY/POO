using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


public class FuncionarioLista
{
    private string nome;
    private string cpf;
    private double salarioBruto;
    private double salarioLiquido;

    public FuncionarioLista(string nome, string cpf, double salarioBruto)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.salarioBruto = salarioBruto;
    }

    public void Salario()
    {
        double desconto = 0;
        if(salarioBruto <= 2000){
            desconto = 0;
        }
        else if (salarioBruto >= 2000.01 && salarioBruto <= 3000)
        {
            desconto = 7.5;
        }
        else if(salarioBruto >= 3000.01 && salarioBruto <= 4000)
        {
            desconto = 15;
        }
        else if(salarioBruto >= 4000.01 && salarioBruto <= 5000)
        {
            desconto = 22.5;
        }
        else
        {
            desconto = 27.5;
        }

        salarioLiquido = salarioBruto - (salarioBruto * (desconto / 100));

        Console.WriteLine($"O funcionario {nome} tem uma salario bruto de {salarioBruto}" +
            $" com um desconto de {desconto}, com um salario liquido de {salarioLiquido}");

    }

}

