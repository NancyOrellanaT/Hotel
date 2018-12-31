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
    class Conexion
    {

        private SqlConnection sqlConnection;

        public Conexion()
        {
            try
            {
                Log.Print("Conectando a la base de datos...");
                sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=hotel;Integrated Security=True");
                sqlConnection.Open();
                Log.Print("Conexión realizada con éxito");
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo conectar a la base de datos: " + e.ToString());
            }
        }

        public void EjecutarSQL(string sql)
        {
            Log.Print("Ejecutando sentencia SQL: " + sql);

            try
            {
                SqlCommand sqlCommand = new SqlCommand(sql);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo ejecutar la sentencia SQL: " + e.ToString());
            }
        }

        public SqlDataReader ConsultaSQL(string sql)
        {
            Log.Print("Ejecutando consulta SQL: " + sql);

            try
            {
                SqlCommand sqlCommand = new SqlCommand(sql);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                return dataReader;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo ejecutar la sentencia SQL: " + e.ToString());
            }

            return null;
        }

        public void Cerrar()
        {
            sqlConnection.Close();
        }

    }
}
