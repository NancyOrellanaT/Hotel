using System;
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
            FrmActualizacionHabitacion frmActualizacionHabitacion = new FrmActualizacionHabitacion();
            frmActualizacionHabitacion.Show();
        }
    }
}
