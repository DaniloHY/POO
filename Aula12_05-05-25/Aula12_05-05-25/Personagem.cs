using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Personagem
{
    private int quantidadeVida;
    private int quantidadeDano;

    List<Personagem> personagemList = new List<Personagem>();

    public int QuantidadeVida { get { return quantidadeVida; } }
    public int QuantidadeDano { get { return quantidadeDano; } }


    public Personagem()
    {
        this.quantidadeDano = 100;
        this.quantidadeVida = 500;
    }
    public Personagem(int quantidadeVida)
    {
        this.quantidadeDano = 100;
        this.quantidadeVida = quantidadeVida;
    }

    public Personagem(int quantidadeVida, int quantidadeDano)
    {
        this.quantidadeDano = quantidadeDano;
        this.quantidadeVida = quantidadeVida;
    }

    public void AdicionarPersonagem(Personagem personagem)
    {
        personagemList.Add(personagem);
    }


    public virtual void AtacarPersonagem(Personagem personagem)
    {
        personagem.quantidadeVida -= this.quantidadeDano;
        if (quantidadeVida < 0)
        {
            Console.WriteLine("O personagem atacado morreu");
        }
        Console.WriteLine($"O personagem tem {personagem.quantidadeVida} de vida");
    }

    public virtual void AtacarPersonagem(List<Personagem> personagem)
    {
        /*personagem.quantidadeVida -= this.quantidadeDano;
        if (quantidadeVida < 0)
        {
            Console.WriteLine("O personagem atacado morreu");
        }
        Console.WriteLine($"O personagem tem {personagem.quantidadeVida} de vida");*/
    }
}
