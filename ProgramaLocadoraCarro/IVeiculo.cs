using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaLocadoraCarro
{
    public interface IVeiculo
    {
        string modelo{ get; }
        string marca { get; }
        int ano { get; }
        double valorDiario { get; }
        bool status { get; }
        double valorTotal { get; }
        public void CalcularAluguel(int dias)
        {

        }
    }
}
