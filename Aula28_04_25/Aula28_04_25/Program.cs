// Interface de POO
using Aula28_04_25;

List<ICarregavel> carregaveis = new List<ICarregavel>();

ICarregavel caminhao = new Caminhao();
ICarregavel balanca = new Balanca();

carregaveis.Add(caminhao);
carregaveis.Add(balanca);

foreach(ICarregavel c in carregaveis)
{
    c.AdicionarCarga(50);
    Console.WriteLine(c);
}
