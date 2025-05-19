using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Loja1 : Estocavel
{
    Dictionary<Produto, int> quantidadeEmEstoque;

    public void Estocar(Produto produto)
    {
        quantidadeEmEstoque.Add(produto, 1);
    }
}

