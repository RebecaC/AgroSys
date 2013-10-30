using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using AgroSys;


namespace AgroSys
{
    public partial class UsuariosHome : Telerik.WinControls.UI.RadForm
    {
        public UsuariosHome()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IngresoUsuarios ingreso = new IngresoUsuarios();
            ingreso.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListarUsuarios lista = new ListarUsuarios();
            lista.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActualizarUsuarios actualizar = new ActualizarUsuarios();
            actualizar.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EliminarUsuarios eliminar = new EliminarUsuarios();
            eliminar.Show();
        }

        private void UsuariosHome_Load(object sender, EventArgs e)
        {
            
        }
    }
}
