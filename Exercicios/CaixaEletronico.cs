using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CaixaEletronico
{
    private List<Cliente> usuarios;
    private Cliente usuarioLogado;

    public CaixaEletronico()
    {
        usuarios = new List<Cliente>();
        usuarioLogado = null;
    }

    public void RegistrarUsuario(string login, string senha)
    {
        usuarios.Add(new Cliente(login, senha));
    }

    public bool Login(string login, string senha)
    {
        foreach (var usuario in usuarios)
        {
            if (usuario.Login == login && usuario.Senha == senha)
            {
                usuarioLogado = usuario;
                return true;
            }
        }
        return false;
    }
    public void Depositar(decimal valor)
    {
        if (usuarioLogado != null)
        {
            usuarioLogado.Saldo += valor;
            usuarioLogado.Extrato.Add($"Depósito: {valor:C}");
        }
    }
    public bool Sacar(decimal valor)
    {
        if (usuarioLogado != null && usuarioLogado.Saldo >= valor)
        {
            usuarioLogado.Saldo -= valor;
            usuarioLogado.Extrato.Add($"Saque: {valor:C}");
            return true;
        }
        return false;
    }
    public decimal VerSaldo()
    {
        if (usuarioLogado != null)
        {
            return usuarioLogado.Saldo;
        }
        return 0;
    }
    public List<string> VerExtrato()
    {
        if (usuarioLogado != null)
        {
            return usuarioLogado.Extrato;
        }
        return new List<string>();
    }

    public void Logout()
    {
        usuarioLogado = null;
    }
}

