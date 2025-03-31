using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cachorro : Domestico, Andar
{
    public Cachorro(string nome, string cor, string endereco)
        : base(nome, cor, "Cachorro", endereco) { }

    public override void FazerSom() => Console.WriteLine("Au Au!");
    public void Andar() => Console.WriteLine("O cachorro está andando.");
}

