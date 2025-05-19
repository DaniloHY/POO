using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class Roupa : Produto
{
    private string tipo;
    private string tamanho;
    private double preco;

    public Roupa(string tipo, string tamanho, double preco)
    {
        this.tipo = tipo;
        this.tamanho = tamanho;
        this.preco = preco;
    }

    public override void CalcularPreco()
    {
        Console.WriteLine("O produto custa: " + preco);
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"É uma {tipo}, da marca {tamanho}");
    }
}

