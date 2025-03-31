/*iFoodApp app = new iFoodApp();

// Adicionando entregadores
app.AdicionarEntregador(new EntregadorMoto { Nome = "Carlos" });
app.AdicionarEntregador(new EntregadorBicicleta { Nome = "João" });

// Criando pedidos
Pedido pedido1 = new Pedido { Distancia = 2, Tipo = "Pizza", Descricao = "Mussarela" };
Pedido pedido2 = new Pedido { Distancia = 6, Tipo = "Esfiha", Descricao = "Carne" };

// Registrando pedidos
app.RegistrarPedido(pedido1);
app.RegistrarPedido(pedido2);
*/
/*
Catalogo catalogo = new Catalogo();

catalogo.AdicionarProduto(new Roupa("Camiseta", "Nike", 99.90m, "M", "Preta"));
catalogo.AdicionarProduto(new Alimento("Refrigerante", "Coca-Cola", 7.50m, "Bebida", DateTime.Now.AddMonths(6), true));
catalogo.AdicionarProduto(new Livro("O Senhor dos Anéis", "HarperCollins", 120.00m, "J.R.R. Tolkien", 1200, true));

Console.WriteLine("Produtos em desconto:");
foreach (var produto in catalogo.ListarProdutosEmDesconto())
{
   Console.WriteLine(produto.Nome);
}
*/
/*
Computador pc = new Computador(
            new CPU(8, 3.5, new DateTime(2020, 1, 1)),
            new MemoriaRAM(16000, new DateTime(2021, 6, 1)),
            new SSD(512, 0.1, new DateTime(2022, 3, 1)),
            new PlacaVideo(8000, new DateTime(2019, 5, 1)),
            new FonteAlimentacao(750, new DateTime(2021, 10, 1))
        );

pc.Ligar();
*/

Time timeA = new Time("Tigres", new List<Jogador>
        {
            new Jogador("Carlos", 1, 1.80),
            new Jogador("Pedro", 2, 1.85),
            new Jogador("Lucas", 3, 1.90),
            new Jogador("Rafael", 4, 1.78),
            new Jogador("Gustavo", 5, 1.92),
            new Jogador("André", 6, 1.76)
        });

Time timeB = new Time("Leões", new List<Jogador>
        {
            new Jogador("João", 7, 1.82),
            new Jogador("Felipe", 8, 1.88),
            new Jogador("Henrique", 9, 1.86),
            new Jogador("Mateus", 10, 1.80),
            new Jogador("Eduardo", 11, 1.90),
            new Jogador("Fernando", 12, 1.78)
        });

Partida partida = new Partida(timeA, timeB);
partida.Jogar();