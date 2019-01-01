using Hotel.Control;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hotel
{
    public partial class FrmRegistroHuespedes : Form
    {
        Conexion conexion;
        int codigoHuespedActualizar;
        public FrmRegistroHuespedes()
        {
            InitializeComponent();
            conexion = new Conexion();
            codigoHuespedActualizar = 0;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            HuespedControl huespedControl = new HuespedControl();
            Huesped huesped = new Huesped(txtNombres.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtCI.Text);
            huespedControl.InsertarHuesped(huesped);

            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            HuespedControl huespedControl = new HuespedControl();
            Huesped huesped = new Huesped(codigoHuespedActualizar,txtNombres.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtCI.Text);
            huespedControl.ActualizarHuesped(huesped);
            huespedControl.Cerrar();

            Close();
        }

        public void CargarDatos(Huesped huesped)
        {
            codigoHuespedActualizar = huesped.CodigoHuesped;
            txtNombres.Text = huesped.Nombres;
            txtApellidoPaterno.Text = huesped.ApellidoPaterno;
            txtApellidoMaterno.Text = huesped.ApellidoMaterno;
            txtCI.Text = huesped.CI;

        }
    }
}
