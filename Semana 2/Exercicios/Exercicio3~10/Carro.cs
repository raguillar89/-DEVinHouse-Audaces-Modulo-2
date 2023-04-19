using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_10
{
    class Carro
    {
        public string marca { get; set; }
        public string modelo { get; set;}
        public string placa { get; set;}
        public string cor { get; set;}
        public string proprietario { get; set;}

        public Carro() { }

        public Carro(string marca, string modelo, string placa, string cor, string proprietario)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.placa = placa;
            this.cor = cor;
            this.proprietario = proprietario;
        }
    }
}
