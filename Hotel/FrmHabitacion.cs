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

        private void btnHabitacionesDisponibles_Click(object sender, EventArgs e)
        {
            HabitacionControl habitacionControl = new HabitacionControl();
            DataTable dt = habitacionControl.ListarHabitacionesDisponibles();

            dataGridView1.DataSource = dt;
        }

    }
}
