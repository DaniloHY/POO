using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class iFoodApp
{
    private List<Entregador> entregadores = new List<Entregador>();

    public void AdicionarEntregador(Entregador entregador)
    {
        entregadores.Add(entregador);
    }

    public void RegistrarPedido(Pedido pedido)
    {
        Console.WriteLine($"Pedido registrado: {pedido.Tipo} - {pedido.Descricao} - Distância: {pedido.Distancia} km");
        SelecionarEntregador(pedido);
    }

    private void SelecionarEntregador(Pedido pedido)
    {
        foreach (var entregador in entregadores)
        {
            if (entregador.PodeEntregar(pedido.Distancia))
            {
                Console.WriteLine($"Entregador {entregador.Nome} selecionado!");
                entregador.RealizarEntrega(pedido);
                return;
            }
        }
        Console.WriteLine("Nenhum entregador disponível para esta distância.");
    }
}

