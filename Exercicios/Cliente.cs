using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cliente
{
    public string Login { get; set; }
    public string Senha { get; set; }
    public decimal Saldo { get; set; }
    public List<string> Extrato { get; set; }

    public Cliente(string login, string senha)
    {
        Login = login;
        Senha = senha;
        Saldo = 0;
        Extrato = new List<string>();
    }
}
