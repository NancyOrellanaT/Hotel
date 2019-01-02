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
        public Huesped huespedSeleccionado;

        public FrmHuesped()
        {
            InitializeComponent();
            listarHuespedes();
        }

        private void btnRegistrarHuesped_Click(object sender, EventArgs e)
        {
            FrmRegistroHuespedes frmMantCliente = new FrmRegistroHuespedes();
            frmMantCliente.Show();       
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listarHuespedes();
        }

        public void listarHuespedes()
        {
            HuespedControl huespedControl = new HuespedControl();
            dgvHuespedes.DataSource = huespedControl.ListarHuespedes();
            huespedControl.Cerrar();
        }

        private void btnEditarHuesped_Click(object sender, EventArgs e)
        {
            if (dgvHuespedes.SelectedRows.Count == 1)
            {
                int codigoHuesped = Convert.ToInt32(dgvHuespedes.CurrentRow.Cells[0].Value);
                HuespedControl huespedControl = new HuespedControl();
                huespedSeleccionado = huespedControl.BuscarHuesped(codigoHuesped);

                FrmActualizacionHuesped frmActualizacionHuesped = new FrmActualizacionHuesped();
                frmActualizacionHuesped.Show();
                frmActualizacionHuesped.CargarDatos(huespedSeleccionado);
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila para poder editar los datos de un huésped.","¡Error!");
            }
        }

        private void btnEliminarHuesped_Click(object sender, EventArgs e)
        {
            if (dgvHuespedes.SelectedRows.Count == 1)
            {
                int codigoHuesped = Convert.ToInt32(dgvHuespedes.CurrentRow.Cells[0].Value);
                HuespedControl huespedControl = new HuespedControl();
                huespedControl.EliminarHuesped(codigoHuesped);
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila para poder editar los datos de un huésped.", "¡Error!");
            }
        }
    }
}
