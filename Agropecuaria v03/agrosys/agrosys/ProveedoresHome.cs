using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Collections;
using System.Linq;

namespace AgroSys
{
    public partial class ProveedoresHome : Telerik.WinControls.UI.RadForm
    {
        public ProveedoresHome()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IngresoProveedor ingreso = new IngresoProveedor();
            ingreso.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActualizarProveedor actualiza = new ActualizarProveedor();
            actualiza.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListarProveedor lista = new ListarProveedor();
            lista.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EliminarProveedores elimina = new EliminarProveedores();
            elimina.Show();
        }
    }
}
