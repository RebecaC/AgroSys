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
    public partial class Proveedores : Telerik.WinControls.UI.RadForm
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModuloProveedor.IngresoProveedor ingreso = new ModuloProveedor.IngresoProveedor();
            ingreso.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModuloProveedor.ActualizarProveedor actualiza = new ModuloProveedor.ActualizarProveedor();
            actualiza.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModuloProveedor.ListarProveedor lista = new ModuloProveedor.ListarProveedor();
            lista.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModuloProveedor.EliminarProveedores elimina = new ModuloProveedor.EliminarProveedores();
            elimina.Show();
        }
    }
}
