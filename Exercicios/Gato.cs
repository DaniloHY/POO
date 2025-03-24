using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Gato : Animal
{
    string cor;
    public string Cor => cor;

    public Gato(string nome, int idade, string cor) : base(idade,nome)
    {
        this.cor = cor;
    }

    public void Miar()
    {
        Console.WriteLine("Seu gato miou");
    }
}

