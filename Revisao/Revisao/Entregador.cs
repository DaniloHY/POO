using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Entregador
{
    public string Nome { get; set; }
    public abstract bool PodeEntregar(double distancia);
    public void RealizarEntrega(Pedido pedido)
    {
        Console.WriteLine($"{Nome} está realizando a entrega do pedido com distância de {pedido.Distancia} km.");
    }
}
