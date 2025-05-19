using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Loja
{
    private string marca;

    public abstract void VenderProduto(Produto produto);
    public abstract void VenderProduto(Produto produto, int quantidade);
}

