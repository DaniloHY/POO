using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Contato
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }

    public Contato(string nome, string email, string telefone)
    {
        Nome = nome;
        Email = email;
        Telefone = telefone;
    }
}

