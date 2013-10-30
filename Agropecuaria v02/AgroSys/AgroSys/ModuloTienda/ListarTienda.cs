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
    public partial class ListarTienda : Telerik.WinControls.UI.RadForm
    {
        public ListarTienda()
        {
            InitializeComponent();
        }

        private void ListarTienda_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agrosysDataSet3.tienda' Puede moverla o quitarla según sea necesario.
            this.tiendaTableAdapter1.Fill(this.agrosysDataSet3.tienda);
            // TODO: esta línea de código carga datos en la tabla 'tienda.tienda' Puede moverla o quitarla según sea necesario.
            this.tiendaTableAdapter.Fill(this.tienda.tienda);

        }
    }
}
