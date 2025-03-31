using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Aluguel
{
    public Livro Livro { get; set; }
    public DateTime DataAluguel { get; set; }

    public Aluguel(Livro livro, DateTime dataAluguel)
    {
        Livro = livro;
        DataAluguel = dataAluguel;
    }
}
