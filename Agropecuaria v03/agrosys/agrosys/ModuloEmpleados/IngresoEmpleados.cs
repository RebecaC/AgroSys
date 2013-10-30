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
    public partial class IngresoEmpleados : Telerik.WinControls.UI.RadForm
    {
        public IngresoEmpleados()
        {
            InitializeComponent();
        }
        public void ShowNotification(string messaje)
        {
            lblMsj.Visible = true;
            lblMsj.Text = messaje.ToString();
        }
        public void SaveEmpleados()
        {
            try
            {

                var primerNombre = txtN.Text.ToString();
                var segundoNombre = txtN2.Text.ToString();
                var primerApellido = txtA.Text.ToString();
                var segundoApellido = txtA2.Text.ToString();
                var telefono = txtT.Text.ToString();
                var direccion = txtD.Text.ToString();
                var nit = txtNIT.Text.ToString();
                var dpi = txtDPI.Text.ToString();
                var tiendaId = Convert.ToInt32( comboBox1.SelectedValue ) ;

                SetEmpleados(primerNombre, segundoNombre, primerApellido, segundoApellido, telefono, direccion, nit, dpi, tiendaId);

            }
            catch (Exception)
            {
                throw new Exception("Hay un problema al guardar el Empleado, por favor intente de nuevo.");
            }

        }
        public void SetEmpleados(string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string telefono, string direccion, string nit, string dpi, int tiendaId)
        {
            try
            {
                empleado objEmpleadoVerificar = new empleado();
                using (agrosysEntitiesFull VerificarEmpleadoEntidad = new agrosysEntitiesFull())
                {
                    objEmpleadoVerificar = VerificarEmpleadoEntidad.empleadoes.Where(s => s.nit == nit || s.dpi == dpi).FirstOrDefault<empleado>();
                }

                if (objEmpleadoVerificar == null)
                {
                    using (agrosysEntitiesFull EmpleadoEntidad = new agrosysEntitiesFull())
                    {
                        empleado objEmpleado = new empleado();

                        objEmpleado.primer_nombre = primerNombre;
                        objEmpleado.segundo_nombre = segundoNombre;
                        objEmpleado.primer_apellido = primerApellido;
                        objEmpleado.segundo_apellido = segundoApellido;
                        objEmpleado.nit = nit;
                        objEmpleado.telefono = telefono;
                        objEmpleado.direccion = direccion;
                        objEmpleado.dpi = dpi;
                        objEmpleado.tienda_id_tienda = tiendaId;
                        EmpleadoEntidad.empleadoes.Add(objEmpleado);
                        EmpleadoEntidad.SaveChanges();
                        string mensaje = "El Empleado con el NIT " + nit + " a sido guardado";
                        ShowNotification(mensaje);
                    }
                }
                else
                {
                    ShowNotification("No se a podido guardar el registro");
                }

            }
            catch (Exception)
            {
                throw new Exception("Hay un problema al guardar la tienda, por favor intente de nuevo.");
            }

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void radTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radLabel7_Click(object sender, EventArgs e)
        {

        }

        private void radLabel6_Click(object sender, EventArgs e)
        {

        }

        private void radLabel5_Click(object sender, EventArgs e)
        {

        }

        private void radLabel4_Click(object sender, EventArgs e)
        {

        }

        private void radLabel3_Click(object sender, EventArgs e)
        {

        }

        private void radLabel2_Click(object sender, EventArgs e)
        {

        }

        private void radLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtPrimerNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void radLabel8_Click(object sender, EventArgs e)
        {

        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void radButton1_Click_1(object sender, EventArgs e)
        {
            SaveEmpleados();
        }

        private void IngresoEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tienda.tienda' Puede moverla o quitarla según sea necesario.
            this.tiendaTableAdapter.Fill(this.tienda.tienda);

        }
    }
}
