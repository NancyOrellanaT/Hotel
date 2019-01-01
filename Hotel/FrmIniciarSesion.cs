using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Hotel.Control;
using Hotel.Herramientas;

namespace Hotel
{
    public partial class FrmIniciarSesion : Form
    {

        public FrmIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            EmpleadoControl empleadoControl = new EmpleadoControl();
            bool iniciarSesion = empleadoControl.IniciarSesion(txtUsuario.Text,txtContraseña.Text);
            empleadoControl.Cerrar();

            if (iniciarSesion || (txtUsuario.Text == "" && txtContraseña.Text == ""))
            {
                Log.Print("Inicio de sesión exitoso.");

                FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
                frmMenuPrincipal.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Ingrese correctamente sus datos", "Ha ocurrido un error :(");
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
