using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace AgroSys.ModuloEmpleados
{
    public partial class ListarEmpleados : Telerik.WinControls.UI.RadForm
    {
        public ListarEmpleados()
        {
            InitializeComponent();
        }

        private void ListarEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agrosysDataSet6.empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.agrosysDataSet6.empleado);

        }
    }
}
