using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Gato : Animal
{


    public Gato(string nome, string raca, int idade) : base(nome, raca, idade)
    {
        
    }

    public override void EmitirSom()
    {
        Console.Write("de miar\n");
    }
}

