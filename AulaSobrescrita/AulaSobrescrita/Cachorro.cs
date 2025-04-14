using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cachorro : Animal
{

    private bool abanarRabo;

    public Cachorro(string nome, string raca, int idade, bool abanarRabo) : base(nome, raca, idade)
    {
        this.abanarRabo = abanarRabo;
    }


    public override void EmitirSom()
    {
        Console.Write("de latir\n");
    }
}
    

