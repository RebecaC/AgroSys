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
    public partial class ListarUsuarios : Telerik.WinControls.UI.RadForm
    {
        public ListarUsuarios()
        {
            InitializeComponent();
        }

        private void ListarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'usarios.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.usarios.usuario);

        }
    }
}
