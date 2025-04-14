using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Guerreiro : Personagem
{
    Random random = new Random();

    public Guerreiro(int quantidadeVida, int quantidadeDano) : base(quantidadeVida, quantidadeDano)
    { 
    
    }

    public override void AtacarPersonagem(Personagem personagem)
    {
        int chance = random.Next(1,101);
        if (chance <= 30)
        {
            Console.WriteLine("Você atacou");
            base.AtacarPersonagem(personagem);
        }
        Console.WriteLine("Você atacou");
        base.AtacarPersonagem(personagem);
    }
}

