using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula28_04_25
{
    public class Caminhao : ICarregavel
    {
        double pesoAtual;

        public void AdicionarCarga(double pesoAtual)
        {
            this.pesoAtual += pesoAtual;
        }

        public override string ToString()
        {
            return "Peso do Caminhão: " + pesoAtual;
        }
    }
}
