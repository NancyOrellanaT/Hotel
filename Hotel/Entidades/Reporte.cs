using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Entidades
{
    class Reporte
    {
        public int CantidadHuespedes { get; set; }
        public float DineroObtenido { get; set; }

        public Reporte(int cantidadH, float dinero)
        {
            CantidadHuespedes = cantidadH;
            DineroObtenido = dinero;
        }
    }
}
