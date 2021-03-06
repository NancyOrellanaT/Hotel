﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class FrmMenuPrincipal : Form
    {
        private int lx, ly;
        private int sw, sh;

        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
        }

        //MÉTODO PARA ARRASTRAR EL FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //MÉTODOS PARA CERRAR,MAXIMIZAR, MINIMIZAR FORMULARIO
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrarla aplicación?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
  
        }

        //MÉTODOS PARA EL MENÚ SLIDER
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 55)
            {
                panelMenu.Width = 230;
            }
            else
               panelMenu.Width = 55;
        }

        private void tmMostrarMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 250)
                this.tmMostrarMenu.Enabled = false;
            else
                panelMenu.Width = panelMenu.Width + 35;
            
        }

        private void tmOcultarMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 55)
                this.tmOcultarMenu.Enabled = false;
            else
                panelMenu.Width = panelMenu.Width - 35;
        }

        //MÉTODO PARA ABRIR FORM DENTRO DE PANEL
        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        //METODO PARA MOSTRAR FORMULARIO DE LOGO Al INICIAR
        private void MostrarFormLogo()
        {
            AbrirFormEnPanel(new FrmLogo());
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            MostrarFormLogo();
        }

        //MÉTODO PARA MOSTRAR FORMULARIO DE LOGO Al CERRAR OTROS FORM 
        private void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            MostrarFormLogo();
        }

        //MÉTODOS PARA ABRIR OTROS FORMULARIOS Y MOSTRAR FORM DE LOGO Al CERRAR 
        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            FrmHabitacion frmHabitacion = new FrmHabitacion();
            frmHabitacion.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frmHabitacion);
        }

        private void btnMembresia_Click(object sender, EventArgs e)
        {
            FrmAsignacionHuespedHabitacion frmAsignacionHuespedHabitacion = new FrmAsignacionHuespedHabitacion();
            frmAsignacionHuespedHabitacion.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frmAsignacionHuespedHabitacion);
        }

        //MÉTODO PARA HORA Y FECHA ACTUAL
        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        //MÉTODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCIÓN
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        //DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
                                
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
          
            region.Exclude(sizeGripRectangle);
            this.panel1ContenedorPrincipal.Region = region;
            this.Invalidate();
        }

        private void btnHuespedes_Click(object sender, EventArgs e)
        {
            FrmHuesped frmHuesped = new FrmHuesped();
            frmHuesped.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frmHuesped);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmIniciarSesion frmIniciarSesion = new FrmIniciarSesion();
            frmIniciarSesion.Show();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FrmReporte frmReporte = new FrmReporte();
            frmReporte.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(frmReporte);
        }

        //COLOR Y GRIP DE RECTANGULO INFERIOR
       protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(57, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmAsignacionHuespedHabitacion());
        }

    }
}
