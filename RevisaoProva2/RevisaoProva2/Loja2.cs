using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Loja2
{
    List<Produto> estoque;

    public void Estocar(Produto produto)
    {
        estoque.Add(produto);
    }
}

