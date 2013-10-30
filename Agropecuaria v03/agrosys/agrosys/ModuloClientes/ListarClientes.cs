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
    public partial class ListarClientes : Telerik.WinControls.UI.RadForm
    {
        public ListarClientes()
        {
            InitializeComponent();
        }

        private void ListarClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agrosysDataSet8.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter1.Fill(this.agrosysDataSet8.cliente);
            // TODO: esta línea de código carga datos en la tabla 'agrosysDataSet4.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.agrosysDataSet4.cliente);

        }
    }
}
