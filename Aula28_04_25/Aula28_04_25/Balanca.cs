using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula28_04_25
{
    public class Balanca : ICarregavel
    {
        double pesoAtual;

        public void AdicionarCarga(double carga)
        {
            this.pesoAtual = carga;
        }

        public override string ToString()
        {
            return "Peso da Balança: " + pesoAtual;
        }
    }
}
