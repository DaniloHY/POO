using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cachorro : Animal
{
    public Cachorro(string nome) : base(nome)
    {
        
    }

    public Cachorro(string nome, string raca) : base(nome, raca) 
    {
      
    }

    public Cachorro(string nome, string raca, int idade) : base(nome, raca, idade)
    {

    }
}

