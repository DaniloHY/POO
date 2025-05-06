using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Gato : Animal
{
    public Gato(string nome) : base(nome)
    {

    }

    public Gato(string nome, string raca) : base(nome, raca) 
    {
 
    }

    public Gato(string nome, string raca, int idade) : base(nome, raca, idade)
    {
    }

}

