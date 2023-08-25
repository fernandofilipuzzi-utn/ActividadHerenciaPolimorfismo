using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadEnElAula
{
    class Seguro : Costo
    {
        public double ValorAsegurado { get; set; }
        public double Porcentaje { get; set; }

        public Seguro(double valorAsegurado, double porcentaje)
        {
            ValorAsegurado = valorAsegurado;
            Porcentaje = porcentaje;
        }

        public override double Valor()
        {
            return Porcentaje/100* ValorAsegurado;
        }

        public override string ToString()
        {
            return $"Seguro (Póliza:{ValorAsegurado:f2}), (Pago:{Porcentaje:f2}%)";
        }
    }
}
