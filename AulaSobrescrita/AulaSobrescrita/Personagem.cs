using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Personagem
{
    private int quantidadeVida;
    private int quantidadeDano;

    public int QuantidadeVida { get { return quantidadeVida; } }
    public int QuantidadeDano{ get { return quantidadeDano; } }

    public Personagem(int quantidadeVida, int quantidadeDano) 
    {
        this.quantidadeDano = quantidadeDano;
        this.quantidadeVida = quantidadeVida;
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
}

