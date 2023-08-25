using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadEnElAula
{
    class Transporte : Costo
    {
        public double Distancia { get; set; }
        public double PrecioPorKm { get; set; }

        public Transporte(double distancia, double precioPorKm)
        {
            Distancia = distancia;
            PrecioPorKm = precioPorKm;
        }

        public override double Valor()
        {
            return PrecioPorKm*Distancia;
        }

        public override string ToString()
        {
            return $"Transporte ({Distancia:f2} km) , ({PrecioPorKm:f2}$/1km) ";
        }
    }
}
