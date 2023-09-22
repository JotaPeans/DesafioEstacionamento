using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DESAFIOESTACIONAMENTO.Models
{
    public class Estacionamento
    {
        public double PrecoInicial { get; private set; }
        public double PrecoPorHora { get; private set; }
        private List<Veiculo>? Veiculos { get; set; }

        public Estacionamento(double precoInicial, double precoPorHora) {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }

        public double GetPrecoInicial() {
            return PrecoInicial;
        }
        public double GetPrecoPorHora() {
            return PrecoPorHora;
        }

        public void AddVeiculo(string placa) {
            Veiculos ??= new();
            // if(Carros == null) {
            //     Carros = new();
            // }
            Veiculos.Add(new Veiculo(placa));
        }

        public void RemoveVeiculo(string placa) {
            Veiculo? carroEstacionado = Veiculos?.Find(carro => carro.Placa == placa);
            if(carroEstacionado == null) {
                Console.WriteLine("Carro com essa placa não existe");
                return;
            }

            Veiculos?.RemoveAll(carro => carro.Placa == placa);
        }

        public void ListaVeiculos() {
            if(Veiculos != null) {
                foreach(Veiculo carro in Veiculos) {
                    Console.WriteLine(carro);
                }
            }
        }

        public double CalcularPreco(int horas) {
            double total = PrecoInicial + ( horas * PrecoPorHora );

            return total;
        }
    }
}