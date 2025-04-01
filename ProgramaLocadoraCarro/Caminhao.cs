using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaLocadoraCarro
{
    public class Caminhao : Veiculo
    {
        public Caminhao(string modelo, string marca, int ano, double valorDiario, bool status) : base(modelo, marca, ano, valorDiario, status)
        {
        }


        public override double CalcularAluguel(int dias)
        {
            return valorDiario * dias - ((valorDiario * dias) * 0.2);
        }
    }
}
