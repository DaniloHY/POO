using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Alimento : Produto
{
    public string Tipo { get; set; } // "Bebida" ou "Comida"
    public DateTime DataValidade { get; set; }
    public bool EmDesconto { get; set; }

    public Alimento(string nome, string marca, decimal preco, string tipo, DateTime dataValidade, bool emDesconto)
        : base(nome, marca, preco)
    {
        Tipo = tipo;
        DataValidade = dataValidade;
        EmDesconto = emDesconto;
    }
}
