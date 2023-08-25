using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadEnElAula
{
    class TasaAduanera:Costo
    {
        public double ValorFijo { get; set; }

        public TasaAduanera(double valor)
        {
            ValorFijo = valor;
        }

        override public double Valor()
        {
            return ValorFijo;
        }

        public override string ToString()
        {
            return $"Tasa aduanera(${ValorFijo:f2})";
        }
    }
}
