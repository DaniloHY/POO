using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AgendaTelefonica
{
    private List<Contato> contatos;

    public AgendaTelefonica()
    {
        contatos = new List<Contato>();
    }

    public void AdicionarContato(Contato contato)
    {
        contatos.Add(contato);
    }

    public void AlterarContato(string nome, string novoEmail, string novoTelefone)
    {
        var contato = contatos.FirstOrDefault(c => c.Nome == nome);
        if (contato != null)
        {
            contato.Email = novoEmail;
            contato.Telefone = novoTelefone;
        }
    }

    public void RemoverContato(string nome)
    {
        contatos.RemoveAll(c => c.Nome == nome);
    }

    public string BuscarContatoPorNome(string nome)
    {
        var contato = contatos.FirstOrDefault(c => c.Nome == nome);
        return contato != null ? contato.Telefone : "Contato não encontrado";
    }

    public string BuscarContatoPorEmail(string email)
    {
        var contato = contatos.FirstOrDefault(c => c.Email == email);
        return contato != null ? contato.Telefone : "Contato não encontrado";
    }

    public void ListarContatos()
    {
        foreach (var contato in contatos)
        {
            Console.WriteLine($"Nome: {contato.Nome}, Email: {contato.Email}, Telefone: {contato.Telefone}");
        }
    }
}

