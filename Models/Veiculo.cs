using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DESAFIOESTACIONAMENTO.Models
{
    public class Veiculo
    {
        public string Placa { get; private set; }

        public Veiculo(string placa) {
            Placa = placa;
        }

        public override string ToString()
        {
            return Placa;
        }
    }
}