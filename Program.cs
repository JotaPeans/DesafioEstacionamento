using DESAFIOESTACIONAMENTO.Models;

namespace Default.Program {
    public class Program {
        public static void Main() {
            Console.WriteLine("Bem vindo ao sistema de estacionamento.");
            Console.WriteLine("Insira o preço inicial do estacionamento:");
            double precoInicial = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o preço por hora do estacionamento:");
            double precoPorHora = Convert.ToDouble(Console.ReadLine());

            Estacionamento estacionamento = new(precoInicial, precoPorHora);
            
            int option;
            string? placa;
            do {
                ShowMenu();
                _ = int.TryParse(Console.ReadLine(), out option);

                switch(option) {
                    case 0:
                        Console.WriteLine("Valor invalido");
                        AwaitUser();
                        break;
                    case 1:
                        Console.WriteLine("Insira a placa do veiculo para adicionar: ");
                        placa = Console.ReadLine();
                        if(placa != null) estacionamento.AddVeiculo(placa);

                        AwaitUser();
                        break;
                    case 2:
                        Console.WriteLine("Insira a placa do veiculos para remover: ");
                        placa = Console.ReadLine();
                        Console.WriteLine("Insira quantas horas o veiculos está estacionado");
                        int horas = Convert.ToInt32(Console.ReadLine());

                        double total = estacionamento.CalcularPreco(horas);
                        if(placa != null) estacionamento.RemoveVeiculo(placa);
                        Console.WriteLine($"O veiculo {placa} foi removido e o preço total é de: R$ {total:0.00}");

                        AwaitUser();
                        break;
                    case 3:
                        estacionamento.ListaVeiculos();
                        AwaitUser();
                        break;
                    case 4:
                        break;
                }
            } while(option != 4);
        }

        public static void ShowMenu() {
            Console.Clear();
            Console.WriteLine("Digite sua opção");
            Console.WriteLine("[1] - Adicionar veiculo");
            Console.WriteLine("[2] - Remover veiculo");
            Console.WriteLine("[3] - Listar veiculos");
            Console.WriteLine("[4] - Encerrar");
        }

        public static void AwaitUser() {
            Console.WriteLine("Enter para continuar");
            Console.ReadLine();
        }
    }
}