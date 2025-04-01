using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaLocadoraCarro
{
    public abstract class Veiculo : IVeiculo
    {
        public string modelo { get;  set; }
        public string marca { get;  set; }
        public int ano { get;  set; }
        public double valorDiario { get;  set; }
        public bool status { get;  set; }
        public double valorTotal { get; set; }

        public Veiculo (string modelo, string marca, int ano, double ValorDiario, bool status)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.ano = ano;
            this.valorDiario = ValorDiario;
            this.status = status; 

    }
        public abstract double CalcularAluguel(int dias);
    }

}
