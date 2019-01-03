using Hotel.Herramientas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Habitacion BuscarHabitacion(string codigoHabitacion)
        {
            string sql = "SELECT * FROM Habitacion WHERE codigoHabitacion = '" + codigoHabitacion + "'";
            SqlDataReader reader = conexion.ConsultaSQL(sql);
            
            while (reader.Read())
            {
                bool disponibilidad = (bool) reader["disponibilidad"];
                string descripcion = reader.GetString(2);
                
                return new Habitacion(codigoHabitacion, disponibilidad, descripcion);
            }

            return new Habitacion();
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
                MessageBox.Show("No se pudo consultar las habitaciones");
                Log.Print(e.ToString());
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
                MessageBox.Show("No se pudo consultar las habitaciones");
                Log.Print(e.ToString());
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
                MessageBox.Show("No se pudo consultar las habitaciones");
                Log.Print(e.ToString());
            }

            return null;
        }

        public void ActualizarHabitacion(Habitacion habitacion)
        {
            int disponibilidad = habitacion.Disponibilidad ? 1 : 0;
            string sql = "UPDATE Habitacion SET disponibilidad = " + disponibilidad + ", descripcion = '" + habitacion.Descripcion + "' WHERE codigoHabitacion = '" + habitacion.CodigoHabitacion + "'";
            conexion.EjecutarSQL(sql);
        }

        public void EliminarHabitacion(int codigoHuesped)
        {
            string sql = "DELETE FROM Habitacion WHERE codigoHabitacion = '" + codigoHuesped + "'";
            conexion.EjecutarSQL(sql);
        }

        public void Cerrar()
        {
            conexion.Cerrar();
        }

    }
}
