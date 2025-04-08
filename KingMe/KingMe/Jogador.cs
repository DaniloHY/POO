using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingMe
{
    public class Jogador
    {
        List<Carta> cartas;
        List<Personagem> personagens;

        public List<Carta> Cartas { get { return cartas; } }
        public List<Personagem> Personagens { get { return personagens; } }

        public Jogador(List<Carta> cartas, List<Personagem> personagems)
        {
           this.cartas = cartas;
           this.personagens = personagems;
        }

    }
}
