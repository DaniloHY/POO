using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Conta
{
    private double saldo;
    private string numeroConta;

    public double Saldo
    {
        get
        {
            return saldo;
        }
    }

    public string NumeroConta
    {
        get { return numeroConta; }
    }


    public Conta(double saldo, string numeroConta) 
    {
        //Criando um contrutor
        //o this.saldo retorna a referência da própria classe, ou seja pega o private double saldo;
        this.saldo = saldo;
        this.numeroConta = numeroConta;
    }   
}

