using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Biblioteca
{
    private List<Livro> catalogo = new List<Livro>();
    private Dictionary<string, int> estoque = new Dictionary<string, int>();

    public void AdicionarLivro(Livro livro, int quantidade)
    {
        catalogo.Add(livro);
        if (estoque.ContainsKey(livro.Titulo))
        {
            estoque[livro.Titulo] += quantidade;
        }
        else
        {
            estoque[livro.Titulo] = quantidade;
        }
    }

    public void RemoverLivro(Livro livro, int quantidade)
    {
        if (estoque.ContainsKey(livro.Titulo) && estoque[livro.Titulo] >= quantidade)
        {
            estoque[livro.Titulo] -= quantidade;
            if (estoque[livro.Titulo] == 0)
            {
                catalogo.Remove(livro);
            }
        }
    }

    public bool AlugarLivro(Pessoa pessoa, string titulo)
    {
        if (pessoa.LivroAlugado == null && estoque.ContainsKey(titulo) && estoque[titulo] > 0)
        {
            var livro = catalogo.FirstOrDefault(l => l.Titulo == titulo);
            if (livro != null)
            {
                pessoa.LivroAlugado = livro;
                estoque[titulo]--;
                return true;
            }
        }
        return false;
    }

    public void ConsultarCatalogo()
    {
        foreach (var livro in catalogo)
        {
            Console.WriteLine($"{livro.Titulo} - {livro.Autor} ({livro.AnoPublicacao}) - Quantidade: {estoque[livro.Titulo]}");
        }
    }

}

