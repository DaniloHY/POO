using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cachorro : Animal
{
    string raca;
    public string Raca => raca;

    public Cachorro(string nome, int idade, string raca) : base(idade,nome)
    {
        this.raca = raca;
    }


    public void Latir()
    {
        Console.WriteLine("Seu cachorro latiu");
    }


}

