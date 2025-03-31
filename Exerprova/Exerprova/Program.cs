using System;
using System.Collections.Generic;
using System.Linq;

// Enum para representar o tipo de livro e suas multas
public enum TipoLivro
{
    Normal,
    Exclusivo
}

Biblioteca biblioteca = new Biblioteca();
Pessoa pessoa = new Pessoa("Ana Silva");

biblioteca.ListarCatalogo();

// Alugar um livro
Livro livroParaAlugar = biblioteca.Catalogo.FirstOrDefault(l => l.Titulo == "A Arte da Guerra");
if (livroParaAlugar != null)
{
    if (biblioteca.LivroExisteNoCatalogo(livroParaAlugar))
    {
        pessoa.AlugarLivro(livroParaAlugar, DateTime.Now.AddDays(-5)); // Alugado há 5 dias
        biblioteca.RemoverLivroDoCatalogo(livroParaAlugar);
        Console.WriteLine($"{pessoa.Nome} alugou o livro '{livroParaAlugar.Titulo}'.");
    }
    else
    {
        Console.WriteLine($"Livro '{livroParaAlugar.Titulo}' não está disponível no catálogo.");
    }
}

biblioteca.ListarCatalogo();

// Devolver o livro
if (livroParaAlugar != null)
{
    pessoa.DevolverLivro(livroParaAlugar, DateTime.Now);
    biblioteca.AdicionarLivroAoCatalogo(livroParaAlugar);
    Console.WriteLine($"{pessoa.Nome} devolveu o livro '{livroParaAlugar.Titulo}'.");
}

biblioteca.ListarCatalogo();

// Alugar múltiplos livros
var livrosParaAlugar = biblioteca.Catalogo.Where(l => l.Tipo == TipoLivro.Exclusivo).ToList();
if (livrosParaAlugar.Any())
{
    foreach (var livro in livrosParaAlugar)
    {
        pessoa.AlugarLivro(livro, DateTime.Now.AddDays(-2));
        biblioteca.RemoverLivroDoCatalogo(livro);
        Console.WriteLine($"{pessoa.Nome} alugou o livro '{livro.Titulo}'.");
    }
}

biblioteca.ListarCatalogo();

// Devolver múltiplos livros
var livrosAlugadosPelaPessoa = pessoa.LivrosAlugados.Select(a => a.Livro).ToList();
foreach (var livro in livrosAlugadosPelaPessoa)
{
    pessoa.DevolverLivro(livro, DateTime.Now);
    biblioteca.AdicionarLivroAoCatalogo(livro);
    Console.WriteLine($"{pessoa.Nome} devolveu o livro '{livro.Titulo}'.");
}

biblioteca.ListarCatalogo();