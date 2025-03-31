using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Livro
{
    public string Titulo { get; set; }
    public TipoLivro Tipo { get; set; }

    public Livro(string titulo, TipoLivro tipo)
    {
        Titulo = titulo;
        Tipo = tipo;
    }

    public decimal CalcularMulta(int diasAtraso)
    {
        if (diasAtraso <= 0)
        {
            return 0;
        }

        switch (Tipo)
        {
            case TipoLivro.Normal:
                return diasAtraso * 2;
            case TipoLivro.Exclusivo:
                return diasAtraso * 5;
            default:
                return 0;
        }
    }

    public override string ToString()
    {
        return $"{Titulo} ({Tipo})";
    }
}
