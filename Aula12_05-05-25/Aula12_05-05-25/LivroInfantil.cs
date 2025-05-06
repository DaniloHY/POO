using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LivroInfantil : Livro
{
    int idadeMinima;

    public LivroInfantil(string titulo, string autor, int idadeMinima) : base(titulo, autor) 
    { 
        this.idadeMinima = idadeMinima;
    }
}

