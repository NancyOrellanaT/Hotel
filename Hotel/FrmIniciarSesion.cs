﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel
{
    public partial class FrmIniciarSesion : Form
    {
        public FrmIniciarSesion()
        {
            InitializeComponent();
            Conectar();
        }

        private void Conectar()
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=hotel;Integrated Security=True");
                conexion.Open();
                MessageBox.Show("Se ha conectado exitosamente a la base de datos");
            } catch(Exception e)
            {
                MessageBox.Show("No se pudo conectar a la base de datos");
            }   
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" && txtContraseña.Text == "")
            {
                FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
                frmMenuPrincipal.Show();
                Hide();
            } else
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
