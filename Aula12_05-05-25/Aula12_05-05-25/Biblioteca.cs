using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Biblioteca
{
    List<Livro> listaLivros = new List<Livro>();
    
    public void AdicionarLivro(Livro livro)
    {
        listaLivros.Add(livro);
    }

    public void BuscarLivro(int idadeM)
    {
        
    }

    public void BuscarLivro(string orcid)
    {
        
    }

}

