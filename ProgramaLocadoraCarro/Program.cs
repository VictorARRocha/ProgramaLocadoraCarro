namespace ProgramaLocadoraCarro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Componentes componentes = new Componentes();
                List<Veiculo> veiculos = new List<Veiculo>();

                int continua = 0;
                while (continua == 0)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("__________________________________");
                    Console.WriteLine("        Locadora Veículos         ");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("Digite: ");
                    Console.WriteLine("1 - Cadastrar veículo");
                    Console.WriteLine("2 - Alugar veículo");
                    Console.WriteLine("3 - Ver veículos ");
                    Console.WriteLine("Qualquer outra coisa para sair");
                    string opc = Console.ReadLine();

                    switch (opc)
                    {
                        case "1":
                            veiculos.Add(componentes.CadastrarVeiculo());
                            break;

                        case "2":
                            componentes.AlugarVeiculos(veiculos);
                            break;

                        case "3":
                            componentes.MostrarVeiculos(veiculos);
                            break;

                        default:
                            Console.WriteLine("Sistema encerrado.");
                            break;
                    }

                    Console.WriteLine("Você deseja continuar?");
                    Console.WriteLine("0 - Sim | 1 - Não");
                    continua = int.Parse(Console.ReadLine());
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
