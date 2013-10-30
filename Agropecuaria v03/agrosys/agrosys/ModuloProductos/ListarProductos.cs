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
    public partial class ListarProductos : Telerik.WinControls.UI.RadForm
    {
        public ListarProductos()
        {
            InitializeComponent();
        }

        private void ListarProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productosFull.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter1.Fill(this.productosFull.producto);
            // TODO: esta línea de código carga datos en la tabla 'productos.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.productos.producto);

        }
    }
}
