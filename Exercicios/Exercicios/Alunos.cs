using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Alunos
{
    public string Nome { get; set; }
    public List<double> Notas { get; set; }

    public Alunos(string nome, List<double> notas)
    {
        Nome = nome;
        Notas = notas;
    }

    public double CalcularMedia()
    {
        double soma = 0;
        foreach (var nota in Notas)
        {
            soma += nota;
        }
        return Notas.Count > 0 ? soma / Notas.Count : 0;
    }
}

