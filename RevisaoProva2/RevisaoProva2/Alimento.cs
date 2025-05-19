using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


public class Alimento : Produto
{
    private string nome;
    private DateTime dataValidade;
    private double preco;

    public Alimento(string nome, DateTime dataValidade, double preco) 
    {
        this.nome = nome;
        this.dataValidade = dataValidade;
        this.preco = preco;
    }

    public override void CalcularPreco()
    {
        Console.WriteLine("O produto custa: " + preco);
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"O produto {nome}, tem sua data de validade no dia {dataValidade}");
    }
}
    

