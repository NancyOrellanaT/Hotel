using System;
using System.Windows.Forms;

namespace Hotel
{
    public partial class FrmAsignacionHuespedHabitacion : Form
    {
        public FrmAsignacionHuespedHabitacion()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarAsignacion_Click(object sender, EventArgs e)
        {
            FrmActualizacionAsignacionHuespedHabitacion frmActualizacionAsignacionHuespedHabitacion = new FrmActualizacionAsignacionHuespedHabitacion();
            frmActualizacionAsignacionHuespedHabitacion.Show();
        }

        private void btnAsignar_Click_1(object sender, EventArgs e)
        {
            FrmSeleccionHuespedes frmSeleccionHuespedes = new FrmSeleccionHuespedes();
            frmSeleccionHuespedes.Show();
        }
    }
}
