using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using AgroSys.ModuloFacturas;


namespace AgroSys
{
    public partial class FacturasHome : Telerik.WinControls.UI.RadForm
    {
        public FacturasHome()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IngresoFacturas ingreso = new IngresoFacturas();
            ingreso.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListarFacturas lista = new ListarFacturas();
            lista.Show();
        }

       
    }
}
