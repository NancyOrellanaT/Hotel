using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Control
{
    class HuespedControl
    {
        private Conexion conexion;

        public HuespedControl()
        {
            conexion = new Conexion();
        }

        public void InsertarHuesped(Huesped huesped)
        {
            string sql = "Insert into Huesped (nombres, apellidoPaterno, apellidoMaterno, CI) values ('" + huesped.Nombres + "','" + huesped.ApellidoPaterno + "','" + huesped.ApellidoMaterno + "','" + huesped.CI + "')";
            conexion.EjecutarSQL(sql);
        }

        public List<Huesped> ListarHuespedes()
        {
            List<Huesped> huespedes = new List<Huesped>();
            string sql = "Select * from Huesped";
            SqlDataReader reader = conexion.ConsultaSQL(sql);

            while (reader.Read())
            {
                Huesped huesped = new Huesped(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                huespedes.Add(huesped);
            }
            return huespedes;
        }

        public Huesped BuscarHuesped(int codigoHuesped)
        {
            string sql = "Select * from Huesped where codigoHuesped = " + codigoHuesped;
            SqlDataReader reader = conexion.ConsultaSQL(sql);
            Huesped huespedSeleccionado = new Huesped();

            while (reader.Read())
            {
                huespedSeleccionado.CodigoHuesped = reader.GetInt32(0);
                huespedSeleccionado.Nombres = reader.GetString(1);
                huespedSeleccionado.ApellidoPaterno = reader.GetString(2);
                huespedSeleccionado.ApellidoMaterno = reader.GetString(3);
                huespedSeleccionado.CI = reader.GetString(4);

            }

            return huespedSeleccionado;
        }

        public void ActualizarHuesped(Huesped huesped)
        {
            string sql = "Update Huesped set nombres = '" + huesped.Nombres + "', apellidoPaterno = '" + huesped.ApellidoPaterno + "', apellidoMaterno = '" + huesped.ApellidoMaterno + "', CI = '" + huesped.CI + "' where codigoHuesped = " + huesped.CodigoHuesped + ";";
            conexion.EjecutarSQL(sql);
        }

        public void EliminarHuesped(int codigoHuesped)
        {
            string sql = "Delete from Huesped where codigoHuesped = " + codigoHuesped + ";";
            conexion.EjecutarSQL(sql);
        }

        public void Cerrar()
        {
            conexion.Cerrar();
        }
    }
}
