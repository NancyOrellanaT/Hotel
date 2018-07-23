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
    }
}
