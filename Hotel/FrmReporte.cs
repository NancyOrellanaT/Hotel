using Hotel.Control;
using Hotel.Entidades;
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
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
            ReporteGeneral();
        }

        public void ReporteGeneral()
        {
            ReporteControl reporteControl = new ReporteControl();
            Reporte reporte = reporteControl.MostrarReporteGeneral();

            /*txtNumeroTotalH.Text = reporte.CantidadHuespedes.ToString();
            txtDineroTotal.Text = reporte.DineroObtenido.ToString();*/
        }

    }
}
