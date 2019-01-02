using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public DataTable ListarHabitaciones()
        {
            try
            {
                string sql = "SELECT * FROM Habitacion";
                SqlDataReader dataReader = conexion.ConsultaSQL(sql);
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);

                return dataTable;
            }
            catch (Exception e)
            {

            }

            return null;
        }

        public DataTable ListarHabitacionesDisponibles()
        {
            try
            {
                string sql = "SELECT * FROM Habitacion WHERE disponibilidad = 1";
                SqlDataReader dataReader = conexion.ConsultaSQL(sql);
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);

                return dataTable;
            }
            catch (Exception e)
            {

            }

            return null;
        }

        public DataTable ListarHabitacaionesNoDisponibles()
        {
            try
            {
                string sql = "SELECT * FROM Habitacion WHERE disponibilidad = 0";
                SqlDataReader dataReader = conexion.ConsultaSQL(sql);
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);

                return dataTable;
            }
            catch (Exception e)
            {

            }

            return null;
        }

        public void Cerrar()
        {
            conexion.Cerrar();
        }
    }
}
