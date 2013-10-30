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
    public partial class ListarRolUsuario : Telerik.WinControls.UI.RadForm
    {
        public ListarRolUsuario()
        {
            InitializeComponent();
        }

        private void ListarRolUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agrosysDataSet.rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.agrosysDataSet.rol);

        }

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }
    }
}
