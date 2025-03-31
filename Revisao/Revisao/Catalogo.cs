using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Catalogo
{
    private List<Produto> produtos = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
    }

    public void RemoverProduto(string nome)
    {
        produtos.RemoveAll(p => p.Nome == nome);
    }

    public List<Produto> BuscarPorNome(string nome)
    {
        return produtos.Where(p => p.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Roupa> BuscarRoupas(string tamanho = null, string cor = null)
    {
        return produtos.OfType<Roupa>().Where(r =>
            (tamanho == null || r.Tamanho == tamanho) &&
            (cor == null || r.Cor == cor)).ToList();
    }

    public List<Alimento> BuscarAlimentos(string tipo = null, DateTime? dataValidade = null)
    {
        return produtos.OfType<Alimento>().Where(a =>
            (tipo == null || a.Tipo == tipo) &&
            (!dataValidade.HasValue || a.DataValidade <= dataValidade.Value)).ToList();
    }

    public List<Livro> BuscarLivros(string titulo = null, string autor = null, int? paginas = null, bool maiorQue = true)
    {
        return produtos.OfType<Livro>().Where(l =>
            (titulo == null || l.Nome.Contains(titulo, StringComparison.OrdinalIgnoreCase)) &&
            (autor == null || l.Autor.Contains(autor, StringComparison.OrdinalIgnoreCase)) &&
            (!paginas.HasValue || (maiorQue ? l.Paginas > paginas : l.Paginas < paginas))).ToList();
    }

    public List<Produto> ListarProdutosEmDesconto()
    {
        return produtos.Where(p => (p is Alimento a && a.EmDesconto) || (p is Livro l && l.EmDesconto)).ToList();
    }
}