using Hotel.Herramientas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Control
{
    class EmpleadoControl
    {

        private Conexion conexion;

        public EmpleadoControl(){
            conexion = new Conexion();
        }

        public bool IniciarSesion(string usuario, string contra)
        {
            string consulta = "SELECT * FROM Empleado WHERE usuario = \'" + usuario + "\' and contraseña = \'" + contra + "\'";
            SqlDataReader reader = conexion.ConsultaSQL(consulta);

            while (reader.Read())
            {
                Log.Print("Se encontró una coincidencia para el inicio de sesión: " + reader.GetString(1) + " " + reader.GetString(2));
                return true;
            }

            return false;
        }

        public void Cerrar()
        {
            conexion.Cerrar();
        }

    }
}
