﻿using Hotel.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Hotel
{
    public partial class FrmActualizacionHuesped : Form
    {
        private int codigoHuespedActualizar;

        public FrmActualizacionHuesped()
        {
            InitializeComponent();
            codigoHuespedActualizar = 0;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            HuespedControl huespedControl = new HuespedControl();
            Huesped huesped = new Huesped(codigoHuespedActualizar, txtNombres.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, txtCI.Text);
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

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}