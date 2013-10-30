using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;


namespace AgroSys
{
    public partial class Clientes : Telerik.WinControls.UI.RadForm
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModuloClientes.IngresoClientes ingreso = new ModuloClientes.IngresoClientes();
            ingreso.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModuloClientes.ListarClientes lista = new ModuloClientes.ListarClientes();
            lista.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModuloClientes.ActualizarClientes actualizar = new ModuloClientes.ActualizarClientes();
            actualizar.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModuloClientes.EliminarClientes eliminar = new ModuloClientes.EliminarClientes();
            eliminar.Show();
        }
    }
}
