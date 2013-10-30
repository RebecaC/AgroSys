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
    public partial class TiendaHome : Telerik.WinControls.UI.RadForm
    {
        public TiendaHome()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IngresoTienda ingreso = new IngresoTienda();
            ingreso.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListarTienda lista = new ListarTienda();
            lista.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActualizarTienda actualizar = new ActualizarTienda();
            actualizar.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EliminarTienda eliminar = new EliminarTienda();
            eliminar.Show();
        }
    }
}
