using System;

namespace Hotel
{
    internal class AsignacionHuespedHabitacion
    {
        public string CodigoAsignacion { get; set; }
        public int CodigoHuesped { get; set; }
        public int CodigoHabitacion { get; set; }
        public int CodigoEmpleado { get; set; }
        public float PrecioPorNoche { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
    }
}