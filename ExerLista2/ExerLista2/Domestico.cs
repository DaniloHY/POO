using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 internal class Domestico : Animal
 {
    private string endereco;

    public Domestico(string nome, string cor, string especie, string endereco) : base(nome, cor, especie)
    {
        this.endereco = endereco;
    }
 }

