using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Peixe : Animal
{
    public Peixe(string nome, string raca, int idade) : base(nome, raca, idade)
    {
        
    }

    public override void EmitirSom()
    {
        Console.Write("de Blub-Blub\n");
    }



}

