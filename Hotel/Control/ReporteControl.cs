using Hotel.Entidades;
using Hotel.Herramientas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Control
{
    class ReporteControl
    {
        Conexion conexion;

        public ReporteControl()
        {
            conexion = new Conexion();
        }

        public Reporte MostrarReporte(DateTime fecha)
        {
            string sql = "SELECT COUNT(AsignacionGrupoHuesped.codigoHuesped) AS Huespedes FROM AsignacionGrupoHabitacion INNER JOIN Grupo ON AsignacionGrupoHabitacion.codigoGrupo = Grupo.codigoGrupo WHERE fechaEntrada >= " + fecha + "AND fechaSalida <= " + fecha;
            SqlDataReader reader = conexion.ConsultaSQL(sql);

            return null;
        }

        public Reporte MostrarReporteGeneral()
        {
            /*try
            {
                string sql = "SELECT COUNT(AsignacionGrupoHuesped.codigoHuesped) AS Huespedes, SUM(AsignacionGrupoHabitacion.precioTotal) AS Monto_Total FROM AsignacionGrupoHabitacion INNER JOIN Grupo ON AsignacionGrupoHabitacion.codigoGrupo = Grupo.codigoGrupo INNER JOIN AsignacionGrupoHuesped ON Grupo.codigoGrupo = AsignacionGrupoHuesped.codigoGrupo";
                SqlDataReader reader = conexion.ConsultaSQL(sql);

                Reporte reporte = new Reporte(reader.GetInt32(0), reader.GetFloat(1));

                return reporte;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error :(");
                Log.Print(e.ToString());
            }*/

            return null;
        }
    }
}
