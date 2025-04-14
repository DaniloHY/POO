using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Animal
{
    private string nome;
    private string raca;
    private int idade;


    public string Nome { get { return nome; } }
    public string Raca { get { return raca; } }
    public int Idade { get { return idade; } }

    public Animal(string nome, string raca, int idade) 
    {
        this.nome = nome;
        this.raca = raca;
        this.idade = idade;
    } 

    public virtual void EmitirSom()
    {

    }
}

