using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Hotel
{
    public partial class FrmRegistroHuespedes : Form
    {
        public FrmRegistroHuespedes()
        {
            InitializeComponent();

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Conexión con la base de datos
        IFirebaseClient client;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "eg8V1I44SwCAS6dNNwDE79S7XzihXaDQ4z4849rq",
            BasePath = "https://hotel-dalias-b7893.firebaseio.com/"
        };

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

        private void FormMantCliente_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client == null)
            {
                MessageBox.Show("Ha ocurrido un error en la conexión");
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            FirebaseResponse resp = await client.GetTaskAsync("Contadores/Contador huéspedes");
            Contador get = resp.ResultAs<Contador>();

            var huesped = new Huesped
            {
                codigoHuesped = (Convert.ToInt32(get.cont_huespedes) + 1).ToString(),
                nombres = txtNombres.Text,
                apellidoPaterno = txtaApellidoPaterno.Text,
                apellidoMaterno = txtApellidoMaterno.Text,
                ci = txtCI.Text
            };

            SetResponse resp1 = await client.SetTaskAsync("Datos huéspedes/" + huesped.codigoHuesped, huesped);
            Huesped result = resp1.ResultAs<Huesped>();

            var obj = new Contador
            {
                cont_huespedes = huesped.codigoHuesped
            };

            SetResponse resp2 = await client.SetTaskAsync("Contadores/Contador huéspedes", obj);
            
            this.Close();
        }
    }
}
