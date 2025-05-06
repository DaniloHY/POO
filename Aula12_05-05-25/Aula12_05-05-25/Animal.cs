using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Animal    
{
    string nome;
    string raca;
    int idade;

    public Animal(string nome) 
    { 
        this.nome = nome;
    }

    public Animal(string nome, string raca)
    {
        this.nome = nome;
        this.raca = raca;
    }

    public Animal(string nome, string raca, int idade)
    {
        this.nome = nome;
        this.raca = raca;
        this.idade = idade;
    }
}

