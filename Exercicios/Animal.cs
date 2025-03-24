using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Animal
{
    protected string nome;
    protected int idade;

    public string Nome => nome;
    public int Idade => idade;


    public Animal(int idade, string nome)
    {
        this.idade = idade;
        this.nome = nome;
    }

    public void Andar()
    {
        Console.WriteLine("Seu animal anda");
    }
}

