using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Eletronico : Produto
{
    private string marca;
    private string modelo;
    private double preco;

    public Eletronico(string marca, string modelo, double preco) 
    { 
        this.marca = marca;
        this.modelo = modelo;
        this.preco = preco;
    }

    public override void CalcularPreco()
    {
        Console.WriteLine("O produto custa: " + preco);
    }

    public override void ExibirInformacoes()
    {
       Console.WriteLine($"É um {modelo}, da marca {marca}");
    }

}
    

