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

        private void FrmAsignacionHuespedHabitacion_Load(object sender, EventArgs e)
        {
        }

        private async void btnAsignar_Click(object sender, EventArgs e)
        {
            var asignacionHuespedHabitacion = new AsignacionHuespedHabitacion
            {
                codigoAsignacion = txtCodigoAsignacion.Text,
                codigoHuesped = txtCodigoHuesped.Text,
                codigoHabitacion = cbCodigoHabitacion.Text,
                precioNoche = txtPrecioNoche.Text,
                tiempoPermanencia = txtTiempoPermanencia.Text,
                fechaEntrada = dateTimePicker1.Text
            };

            txtCodigoAsignacion.Text = "";
            txtCodigoHuesped.Text = "";
            txtPrecioNoche.Text = "";
            txtTiempoPermanencia.Text = "";
            txtTotalPagar.Text = "";
        }
    }
}
