using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace COMPLETE_FLAT_UI
{
    public partial class FrmAsignacionHuespedHabitacion : Form
    {
        public FrmAsignacionHuespedHabitacion()
        {
            InitializeComponent();
        }

        //Conexión con la base de datos
        IFirebaseClient client;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "eg8V1I44SwCAS6dNNwDE79S7XzihXaDQ4z4849rq",
            BasePath = "https://hotel-dalias-b7893.firebaseio.com/"
        };

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAsignacionHuespedHabitacion_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                MessageBox.Show("Conectado correctamente!");
            }
        }
    }
}
