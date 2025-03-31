using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Animal
{
    private string nome;
    private string cor;
    private string especie;

    public Animal(string nome, string cor, string especie)
    {
        this.nome = nome;
        this.cor = cor;
        this.especie = especie;
    }


    public abstract void FazerSom();


    
}

