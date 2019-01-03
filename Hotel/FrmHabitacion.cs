using Hotel.Control;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel
{
    public partial class FrmHabitacion : Form
    {
        public FrmHabitacion()
        {
            InitializeComponent();
        }

        private void btnRegistrarHabitacion_Click(object sender, EventArgs e)
        {
            FrmRegistroHabitacion frmRegistroHabitacion = new FrmRegistroHabitacion();
            frmRegistroHabitacion.Show();
        }

        private void btnEditarHabitacion_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string codigoHabitacion = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                HabitacionControl habitacionControl = new HabitacionControl();
                Habitacion habitacion = habitacionControl.BuscarHabitacion(codigoHabitacion);

                FrmActualizacionHabitacion frmActualizacionHabitacion = new FrmActualizacionHabitacion();
                frmActualizacionHabitacion.Show();
                frmActualizacionHabitacion.CargarDatos(habitacion);
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila para poder editar los datos de un huésped.", "¡Error!");
            }

            
        }

        private void btnHabitacionesDisponibles_Click(object sender, EventArgs e)
        {
            HabitacionControl habitacionControl = new HabitacionControl();
            DataTable dt = habitacionControl.ListarHabitacionesDisponibles();
            habitacionControl.Cerrar();

            dataGridView1.DataSource = dt;
        }

        private void btnListarHabitaciones_Click(object sender, EventArgs e)
        {
            HabitacionControl habitacionControl = new HabitacionControl();
            DataTable dt = habitacionControl.ListarHabitaciones();
            habitacionControl.Cerrar();

            dataGridView1.DataSource = dt;
        }

        private void btnHabitacionesNoDisponibles_Click(object sender, EventArgs e)
        {
            HabitacionControl habitacionControl = new HabitacionControl();
            DataTable dt = habitacionControl.ListarHabitacaionesNoDisponibles();
            habitacionControl.Cerrar();

            dataGridView1.DataSource = dt;
        }
    }
}
