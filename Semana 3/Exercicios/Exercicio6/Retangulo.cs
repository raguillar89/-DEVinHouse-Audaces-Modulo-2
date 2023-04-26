using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Retangulo
    {
        private double _Largura;
        private double _Altura;

        public Retangulo(double largura, double altura)
        {
            _Largura = largura;
            _Altura = altura;
        }

        public double Largura
        {
            get { return _Largura; }
            set { _Largura = value; }
        }

        public double Altura
        {
            get { return _Altura; }
            set { _Altura = value; }
        }

        public void AreaRetangula()
        {
            if(Largura > 0 && Altura > 0)
            {
                double area = Largura * Altura;
                Console.WriteLine($"Área do Retangulo: {area}m².");
            }
            else
            {
                Console.WriteLine("Só serão aceitos valores maiores que 0.");
            }
        }
    }
}
