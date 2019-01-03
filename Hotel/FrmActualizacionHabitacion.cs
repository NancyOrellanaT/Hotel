using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Hotel.Control;

namespace Hotel
{
    public partial class FrmActualizacionHabitacion : Form
    {
        public FrmActualizacionHabitacion()
        {
            InitializeComponent();
        }

        public void CargarDatos(Habitacion habitacion)
        {
            txtCodigoHabitacion.Text = habitacion.CodigoHabitacion;
            cbDisponibilidad.Text = habitacion.Disponibilidad? "Disponible":"Ocupado";
            txtDescripcion.Text = habitacion.Descripcion;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            HabitacionControl habitacionControl = new HabitacionControl();
            habitacionControl.ActualizarHabitacion(new Habitacion(txtCodigoHabitacion.Text, cbDisponibilidad.Text == "Disponible", txtDescripcion.Text));
            habitacionControl.Cerrar();

            Close();
        }
    }
}
