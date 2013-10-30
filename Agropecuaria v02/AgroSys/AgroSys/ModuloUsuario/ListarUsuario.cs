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
    public partial class ListarUsuario : Telerik.WinControls.UI.RadForm
    {
        public ListarUsuario()
        {
            InitializeComponent();
        }

        private void ListarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agrosysDataSet4.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.agrosysDataSet4.cliente);

        }

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }
    }
}
