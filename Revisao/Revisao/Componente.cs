using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Componente
{
    public DateTime DataFabricacao { get; set; }
    private static Random random = new Random();

    protected Componente(DateTime dataFabricacao)
    {
        DataFabricacao = dataFabricacao;
    }

    public bool Inicializar()
    {
        int anos = DateTime.Now.Year - DataFabricacao.Year;
        double chanceFalha = anos * 0.05; // 5% a mais de falha por ano
        return random.NextDouble() > chanceFalha;
    }
}
