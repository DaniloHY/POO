using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Biblioteca
{
    public List<Livro> Catalogo { get; set; }

    public Biblioteca()
    {
        Catalogo = new List<Livro>();
        // Adicionando alguns livros de exemplo
        Catalogo.Add(new Livro("A Arte da Guerra", TipoLivro.Normal));
        Catalogo.Add(new Livro("O Senhor dos Anéis", TipoLivro.Exclusivo));
        Catalogo.Add(new Livro("Dom Quixote", TipoLivro.Normal));
    }

    public bool LivroExisteNoCatalogo(Livro livro)
    {
        return Catalogo.Contains(livro);
    }

    public void RemoverLivroDoCatalogo(Livro livro)
    {
        Catalogo.Remove(livro);
    }

    public void AdicionarLivroAoCatalogo(Livro livro)
    {
        Catalogo.Add(livro);
    }

    public void ListarCatalogo()
    {
        Console.WriteLine("--- Catálogo da Biblioteca ---");
        foreach (var livro in Catalogo)
        {
            Console.WriteLine(livro);
        }
        Console.WriteLine("-----------------------------");
    }
}
