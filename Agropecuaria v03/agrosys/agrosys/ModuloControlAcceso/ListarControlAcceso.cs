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
    public partial class ListarControlAcceso : Telerik.WinControls.UI.RadForm
    {
        public ListarControlAcceso()
        {
            InitializeComponent();
        }

        private void ListarControlAcceso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agrosysDataSet7.control_acceso' Puede moverla o quitarla según sea necesario.
            this.control_accesoTableAdapter.Fill(this.agrosysDataSet7.control_acceso);

        }
    }
}
