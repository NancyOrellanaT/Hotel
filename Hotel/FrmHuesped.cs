using Hotel.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class FrmHuesped : Form
    {
        public FrmHuesped()
        {
            InitializeComponent();
        }

        private void btnRegistrarHuesped_Click(object sender, EventArgs e)
        {
            FrmRegistroHuespedes frmMantCliente = new FrmRegistroHuespedes();
            frmMantCliente.Show();       
        }

        private void btnListarHuespes_Click(object sender, EventArgs e)
        {
            HuespedControl huespedControl = new HuespedControl();
            dgvHuespedes.DataSource = huespedControl.ListarHuespedes();
            huespedControl.Cerrar();
        }
    }
}
