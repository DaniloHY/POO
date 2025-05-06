using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Arqueiro : Personagem
{
    private int quantidadeFlechas;

    public Arqueiro(int quantidadeVida, int quantidadeDano, int quantidadeFlechas) : base(quantidadeVida, quantidadeDano)
    {
        this.quantidadeFlechas = quantidadeFlechas;
    }

    public override void AtacarPersonagem(Personagem personagem)
    {
        if (quantidadeFlechas <= 0)
        {
            Console.WriteLine("Você está sem flechas");

        }
        else
        {
            Console.WriteLine("Você atacou");
            base.AtacarPersonagem(personagem);
            quantidadeFlechas--;
        }
    }


}

