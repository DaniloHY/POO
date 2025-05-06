using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LivroAcademico : Livro
{
    string orcid;

    public LivroAcademico(string titulo, string autor, string orcid) : base(titulo, autor) 
    { 
        this.orcid = orcid;
    } 
}

