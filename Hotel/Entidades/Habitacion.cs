﻿namespace Hotel
{
    class Habitacion
    {
        public string CodigoHabitacion { get; set; }
        public bool Disponibilidad { get; set; }
        public string Descripcion { get; set; }

        public Habitacion(string codigoHabitacion, bool disponibilidad, string descripcion)
        {
            CodigoHabitacion = codigoHabitacion;
            Disponibilidad = disponibilidad;
            Descripcion = descripcion;
        }
    }
}