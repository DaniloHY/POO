using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Selvagem : Animal
{
    private string habitat;

    public Selvagem(string nome, string cor, string especie, string habitat) : base (nome,cor,especie)
    {
        this.habitat = habitat;
    }
}

