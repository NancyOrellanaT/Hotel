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
            string sql = "Insert Into Huesped (nombres, apellidoPaterno, apellidoMaterno, CI) values ('" + huesped.Nombres + "','" + huesped.ApellidoPaterno + "','" + huesped.ApellidoMaterno + "','" + huesped.CI + "')";
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

        public void Cerrar()
        {
            conexion.Cerrar();
        }
    }
}
