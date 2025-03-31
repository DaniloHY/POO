using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Time
{
    public string Nome { get; }
    public List<Jogador> Jogadores { get; }
    public int Pontos { get; set; }

    public Time(string nome, List<Jogador> jogadores)
    {
        Nome = nome;
        Jogadores = jogadores;
        Pontos = 0;
    }
}
