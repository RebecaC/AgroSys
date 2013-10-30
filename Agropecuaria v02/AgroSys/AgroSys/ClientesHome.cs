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
    public partial class ClientesHome : Telerik.WinControls.UI.RadForm
    {
        public ClientesHome()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IngresoClientes ingreso = new IngresoClientes();
            ingreso.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListarClientes lista = new ListarClientes();
            lista.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActualizarClientes actualizar = new ActualizarClientes();
            actualizar.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EliminarClientes eliminar = new EliminarClientes();
            eliminar.Show();
        }

        private void ClientesHome_Load(object sender, EventArgs e)
        {
            
        }
    }
}
