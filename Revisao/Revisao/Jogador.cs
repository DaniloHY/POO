using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Jogador
{
    public string Nome { get; }
    public int Numero { get; }
    public double Altura { get; }
    public bool PodeSacar { get; set; }

    public Jogador(string nome, int numero, double altura)
    {
        Nome = nome;
        Numero = numero;
        Altura = altura;
        PodeSacar = false;
    }

    public bool Sacar()
    {
        return PodeSacar;
    }

    public bool Levantar()
    {
        return true;
    }

    public bool Atacar(bool bolaLevantada)
    {
        Random rand = new Random();
        int chance = bolaLevantada ? 70 : 40;
        return rand.Next(100) < chance;
    }
}
