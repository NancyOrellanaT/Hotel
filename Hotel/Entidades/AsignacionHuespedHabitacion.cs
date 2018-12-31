using System;

namespace Hotel
{
    internal class AsignacionHuespedHabitacion
    {
        public string CodigoAsignacion { get; set; }
        public string CodigoHuesped { get; set; }
        public string CodigoHabitacion { get; set; }
        public string PrecioNoche { get; set; }
        public DateTime TiempoPermanencia { get; set; }
        public DateTime FechaEntrada { get; set; }
    }
}