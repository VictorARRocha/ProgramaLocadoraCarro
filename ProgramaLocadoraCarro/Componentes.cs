using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaLocadoraCarro
{
    public class Componentes
    {

        public Veiculo CadastrarVeiculo()
        {
            try
            {
                Console.WriteLine("Digite o modelo do veículo");
                string modelo = Console.ReadLine();

                Console.WriteLine("Digite a marca do veículo");
                string marca = Console.ReadLine();

                Console.WriteLine("Digite o ano do veículo");
                int ano = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor base da diária do aluguel do veículo");
                double valorBase = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite qual tipo de veiculo você deseja (Caminhão, Carro ou Moto): ");
                string tipoVeiculo = Console.ReadLine();

                if ((modelo.Equals(null)) || (marca.Equals(null)) || ano == null || valorBase == null)
                {
                    Console.WriteLine("Digite um valor válido");
                    return CadastrarVeiculo();
                }
                else
                {
                    switch (tipoVeiculo.ToLower())
                    {
                        case "carro":
                            return new Carro(modelo, marca, ano, valorBase, true);

                        case "moto":
                            return new Moto(modelo, marca, ano, valorBase, true);

                        case "caminhao":
                            return new Caminhao(modelo, marca, ano, valorBase, true);

                        default:
                            Console.WriteLine("Digite uma opção válida");
                            return CadastrarVeiculo();

                    }

                }
            
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString());
                return CadastrarVeiculo();
            }

        }

        public void MostrarVeiculos(List<Veiculo> veiculos)
        {
            Console.Clear();
            foreach(var a in veiculos)
            {
                string livre = a.status ? "Livre" : "Alugado";
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"Modelo: {a.modelo} | Marca: {a.marca} | Ano: {a.ano} | Valor da Diaria: {a.valorDiario} | Status: {livre} | Valor total: {a.valorTotal}");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            }
            

        }

        public bool ProcurarVeiculos(List<Veiculo> veiculos, string modelo)
        {
            foreach (var a in veiculos)
            {
                if (modelo.ToLower() == a.modelo)
                {
                    return true;
                }
  
            }
            return false;
        }


        public void AlugarVeiculos(List<Veiculo> veiculos)
        {
            Console.Clear();
            Console.WriteLine("Veiculos: ");
            MostrarVeiculos(veiculos);
            Console.WriteLine("Digite o modelo que deseja alugar");
            string modelo = Console.ReadLine();
            Veiculo veiculo = veiculos.Find(x => x.modelo == modelo);

            if (veiculo.status == false)
            {
                Console.WriteLine("Veiculo já foi alugado");
            }
            else
            {
                veiculo.status = false;

                Console.WriteLine("Quantos dias vão ser alugados: ");
                int diaria = int.Parse(Console.ReadLine());
                veiculo.valorTotal = veiculo.CalcularAluguel(diaria);
                Console.WriteLine($"O valor total vai ser: {veiculo.valorTotal}");
            }

        }
    }


}
