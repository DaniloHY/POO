using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Pessoa
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public Livro LivroAlugado { get; set; }

    public Pessoa(string nome, string cpf)
    {
        Nome = nome;
        CPF = cpf;
        LivroAlugado = null;
    }
}

