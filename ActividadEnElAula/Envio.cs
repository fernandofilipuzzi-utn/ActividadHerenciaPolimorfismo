using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace ActividadEnElAula
{
    class Envio
    {
        ArrayList costos = new ArrayList();
        public int CantidadCostos 
        { 
            get 
            {
                return costos.Count;
            }
        }

        public void AgregarCosto(Costo costo) 
        {
            costos.Add(costo);
        }

        public double ValorFinal()
        {
            double total=0;
            foreach (Costo costo in costos)
            {
                total += costo.Valor();
            }
            return total;
        }

        public Costo VerCosto(int idx)
        {
            return (Costo)costos[idx];
        }
    }

}
