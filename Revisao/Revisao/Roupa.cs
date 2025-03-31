using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Roupa : Produto
{
    public string Tamanho { get; set; }
    public string Cor { get; set; }

    public Roupa(string nome, string marca, decimal preco, string tamanho, string cor) : base(nome, marca, preco)
    {
        Tamanho = tamanho;
        Cor = cor;
    }
}