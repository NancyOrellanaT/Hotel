using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Cerrar()
        {
            conexion.Cerrar();
        }
    }
}
