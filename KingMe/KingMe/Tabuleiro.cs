using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingMe
{
    public class Tabuleiro
    {
        Dictionary<Setor, List<Personagem>> setorPersonagens;

        public Tabuleiro()
        {
            setorPersonagens = new Dictionary<Setor, List<Personagem>>();
        }

        public void MoverPersonagem(Personagem personagem)
        {
            foreach (Setor setor in setorPersonagens.Keys)
            {
                Setor setorAtual = Setor.LIXEIRA;
                if (setorPersonagens[setor].Contains(personagem))
                {
                    setorAtual = setor;
                }
                else
                {
                    break;
                }

                if(setorAtual == Setor.REI)
                {
                    //Inciar votação
                    return;
                }
                
                switch (setorAtual)
                {
                    case Setor.SETOR_A:
                        List<Personagem> list = setorPersonagens[Setor.SETOR_A];
                        if (list.Count < 4)
                        {
                            //Adicionar Persongaem
                        }
                        break;
                }
            }
        }
    }
}
