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
    public partial class IngresoUsuario : Telerik.WinControls.UI.RadForm
    {
        public IngresoUsuario()
        {
            InitializeComponent();
        }

        private void IngresoUsuario_Load(object sender, EventArgs e)
        {
        

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        public  void SaveUsuario()
        {
            agrosysEntitiesFull entidad = new agrosysEntitiesFull();
            usuario user = new usuario();
            rol roluser = new rol();
            user.nombre_usuario = txtUsuario.Text.ToString();
            user.password = txtPassword.Text.ToString();
            user.rol_id_rol = Convert.ToInt32( ddlRol.SelectedValue);
            user.empleado_id_empleado = Convert.ToInt32( ddlEmpleado.SelectedValue);

            using (var ctx = new agrosysEntitiesFull())
            {
             
                ctx.Set<usuario>().Remove(user);
            }

            entidad.usuarios.Add(user);

        }
        public void LimpiarCampos() 
        {
            txtPassword.Text = "";
            txtUsuario.Text = "";
        }
        private void radButton1_Click(object sender, EventArgs e)
        {
            SaveUsuario();
        }

    }
}
