using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingMe
{
    public class Personagem
    {
        private string nome;
        private string imagem;

        public string Nome { get { return nome; } }
        public string Imagem { get { return imagem; } }

        public Personagem(string nome, string personagem) { 
            this.nome = nome;
            this.imagem = personagem;
        }  
    }
}
