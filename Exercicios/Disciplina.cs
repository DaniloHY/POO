using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Disciplina
{
    public string Nome { get; set; }
    public double NotaAprovacao { get; set; }
    public List<Alunos> Aluno { get; set; }

    public Disciplina(string nome, double notaAprovacao)
    {
        Nome = nome;
        NotaAprovacao = notaAprovacao;
        Aluno = new List<Alunos>();
    }

    public void AdicionarAluno(Alunos aluno)
    {
        Aluno.Add(aluno);
    }
}

