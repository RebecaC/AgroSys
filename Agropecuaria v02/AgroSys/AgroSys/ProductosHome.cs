using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using AgroSys.ModuloProductos;

namespace AgroSys
{
    public partial class ProductosHome : Telerik.WinControls.UI.RadForm
    {
        public ProductosHome()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IngresoProducto ingresa = new IngresoProducto();
            ingresa.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListarProductos lista = new ListarProductos();
            lista.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActualizarProductos actu = new ActualizarProductos();
            actu.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EliminarProductos elimina = new EliminarProductos();
            elimina.Show();
        }
    }
}
