using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Passaro : Animal
{
    private bool voar;

    public Passaro(string nome, string raca, int idade, bool voar) : base(nome, raca, idade)
    {
        this.voar = voar;
    }

    public override void EmitirSom()
    {
        Console.Write("de Piu-Piu\n");
    }
}

