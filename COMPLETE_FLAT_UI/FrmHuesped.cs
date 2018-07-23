using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class FrmHuesped : Form
    {
        public FrmHuesped()
        {
            InitializeComponent();
        }

        private void btnRegistrarHuesped_Click(object sender, EventArgs e)
        {
            FrmRegistroHuesped formMantCliente = new FrmRegistroHuesped();
            formMantCliente.Show();
        }
    }
}
