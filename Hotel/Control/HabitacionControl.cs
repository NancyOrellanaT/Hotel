using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Control
{
    class HabitacionControl
    {
        Conexion conexion;

        public HabitacionControl()
        {
            conexion = new Conexion();
        }

        public void InsertarHabitacion(Habitacion habitacion)
        {
            int disponibilidad = habitacion.Disponibilidad ? 1 : 0;
            string sql = "Insert into Habitacion (codigoHabitacion, disponibilidad, descripcion) values ('" + habitacion.CodigoHabitacion + "'," + disponibilidad + ",'" + habitacion.Descripcion + "')";
            conexion.EjecutarSQL(sql);
        }

        public void Cerrar()
        {
            conexion.Cerrar();
        }
    }
}
