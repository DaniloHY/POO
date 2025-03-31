using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Livro : Produto
{
    public string Autor { get; set; }
    public int Paginas { get; set; }
    public bool EmDesconto { get; set; }

    public Livro(string nome, string marca, decimal preco, string autor, int paginas, bool emDesconto)
        : base(nome, marca, preco)
    {
        Autor = autor;
        Paginas = paginas;
        EmDesconto = emDesconto;
    }
}
