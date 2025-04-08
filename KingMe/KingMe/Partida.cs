using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingMe
{
    public class Partida
    {
        List<Jogador> jogadores;
        Tabuleiro tabuleiro;

        public Partida(List<Jogador> jogadores) 
        { 
            this.jogadores = jogadores;
            tabuleiro = new Tabuleiro();
        }
        
    }
}
