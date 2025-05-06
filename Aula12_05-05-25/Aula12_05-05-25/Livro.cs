using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Livro    
{
        string titulo;
        string autor;

    public Livro(string titulo, string autor)
    {
        this.titulo = titulo;
        this.autor = autor;
    }    
}

