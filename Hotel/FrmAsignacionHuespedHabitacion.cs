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

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditarAsignacion_Click(object sender, EventArgs e)
        {
            FrmActualizacionAsignacionHuespedHabitacion frmActualizacionAsignacionHuespedHabitacion = new FrmActualizacionAsignacionHuespedHabitacion();
            frmActualizacionAsignacionHuespedHabitacion.Show();
        }
    }
}
