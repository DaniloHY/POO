using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Produto
{
    public string Nome { get; set; }
    public string Marca { get; set; }
    public decimal Preco { get; set; }

    protected Produto(string nome, string marca, decimal preco)
    {
        Nome = nome;
        Marca = marca;
        Preco = preco;
    }
}