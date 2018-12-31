using System;

namespace Hotel
{
    internal class AsignacionHuespedHabitacion
    {
        public int CodigoAsignacion { get; set; }
        public int CodigoHuesped { get; set; }
        public int CodigoHabitacion { get; set; }
        public int CodigoEmpleado { get; set; }
        public float PrecioPorNoche { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }

        public AsignacionHuespedHabitacion(int codigoHuesped, int codigoHabitacion, int codigoEmpleado, float precioNoche, DateTime fechaEntrada, DateTime fechaSalida)
        {
            CodigoHuesped = codigoHuesped;
            CodigoHabitacion = codigoHabitacion;
            CodigoEmpleado = codigoEmpleado;
            PrecioPorNoche = precioNoche;
            FechaEntrada = fechaEntrada;
            FechaSalida = fechaSalida;
        }

    }
}