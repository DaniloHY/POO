Biblioteca biblioteca = new Biblioteca();

Livro livro1 = new Livro("Cálculo", "Stewart", 2015);
Livro livro2 = new Livro("Algoritmos", "Cormen", 2009);

biblioteca.AdicionarLivro(livro1, 2);
biblioteca.AdicionarLivro(livro2, 3);

Pessoa pessoa = new Pessoa("João", "12345678900");

biblioteca.ConsultarCatalogo();

if (biblioteca.AlugarLivro(pessoa, "Cálculo"))
{
    Console.WriteLine($"{pessoa.Nome} alugou o livro {pessoa.LivroAlugado.Titulo}");
}
else
{
    Console.WriteLine($"{pessoa.Nome} não conseguiu alugar o livro.");
}

biblioteca.ConsultarCatalogo();
