using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pessoa
{
    public string Nome { get; set; }
    public List<Aluguel> LivrosAlugados { get; set; }

    public Pessoa(string nome)
    {
        Nome = nome;
        LivrosAlugados = new List<Aluguel>();
    }

    public void AlugarLivro(Livro livro, DateTime dataAluguel)
    {
        LivrosAlugados.Add(new Aluguel(livro, dataAluguel));
    }

    public void DevolverLivro(Livro livro, DateTime dataDevolucao)
    {
        var aluguel = LivrosAlugados.FirstOrDefault(a => a.Livro == livro);
        if (aluguel != null)
        {
            LivrosAlugados.Remove(aluguel);
            int diasAtraso = (dataDevolucao - aluguel.DataAluguel).Days;
            if (diasAtraso > 0)
            {
                decimal multa = livro.CalcularMulta(diasAtraso);
                Console.WriteLine($"Multa para o livro '{livro.Titulo}': R$ {multa:F2}");
            }
        }
        else
        {
            Console.WriteLine($"Erro: Livro '{livro.Titulo}' não encontrado nos aluguéis de {Nome}.");
        }
    }
}
