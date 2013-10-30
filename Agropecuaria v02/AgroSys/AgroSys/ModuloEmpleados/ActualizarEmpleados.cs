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

namespace AgroSys.ModuloEmpleados
{
    public partial class ActualizarEmpleados : Telerik.WinControls.UI.RadForm
    {
        public ActualizarEmpleados()
        {
            InitializeComponent();
        }

        private void ActualizarEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agrosysDataSet5.empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.agrosysDataSet5.empleado);
            // TODO: esta línea de código carga datos en la tabla 'tienda.tienda' Puede moverla o quitarla según sea necesario.
            this.tiendaTableAdapter.Fill(this.tienda.tienda);

        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void UpdateEmpleado(string NITempleado, int empleadoID, string dpi)
        {

            empleado objEmpleado = new empleado();
            empleado objTiendaVerificar = new empleado();


            using (agrosysEntitiesFull VerificarTiendaEntidad = new agrosysEntitiesFull())
            {
                objTiendaVerificar = VerificarTiendaEntidad.empleadoes
                    .Where(s => s.id_empleado != empleadoID && (s.nit == NITempleado || s.dpi == dpi))
                    .FirstOrDefault<empleado>();
            }
            if (objTiendaVerificar == null)
            {
                using (agrosysEntitiesFull empleadoEntidad = new agrosysEntitiesFull())
                {
                    objEmpleado = empleadoEntidad.empleadoes.Where(s => s.id_empleado == empleadoID).FirstOrDefault<empleado>();
                }
                int tiendaId =  Convert.ToInt32(comboBox1.SelectedValue);
                objEmpleado.primer_nombre = txtN.Text.ToString();
                objEmpleado.segundo_nombre = txtN2.Text.ToString();
                objEmpleado.primer_apellido = txtA.Text.ToString();
                objEmpleado.segundo_apellido = txtA2.Text.ToString();
                objEmpleado.telefono = txtT.Text.ToString();
                objEmpleado.nit = txtNIT.Text.ToString();
                objEmpleado.direccion = txtNIT.Text.ToString();
                objEmpleado.dpi = txtDPI.Text.ToString();

                using (agrosysEntitiesFull empleadoEntidad = new agrosysEntitiesFull())
                {
                    empleadoEntidad.Entry(objEmpleado).State = System.Data.EntityState.Modified;
                    empleadoEntidad.SaveChanges();
                }
                HideButtom();
                ShowNotification("Su registro a sido actualizado!");
            }
            else
            {
                ShowNotification("Ya existe empleado  con ese NIT!");
            }

        }

        public void FillEmpleado()
        {

            empleado objempleado = new empleado();
            int empleadoID = Convert.ToInt32(comboBox2.SelectedValue);
            // Get tienda from DB
            using (agrosysEntitiesFull empleadoEntidad = new agrosysEntitiesFull())
            {
                objempleado = empleadoEntidad.empleadoes.Where(s => s.id_empleado == empleadoID).FirstOrDefault<empleado>();
            }
            txtN.Text = objempleado.primer_nombre.ToString();
            txtN2.Text = objempleado.segundo_nombre.ToString();
            txtA.Text = objempleado.primer_apellido.ToString();
            txtA2.Text = objempleado.segundo_apellido.ToString();
            txtD.Text = objempleado.direccion.ToString();
            txtT.Text = objempleado.telefono.ToString();
            txtNIT.Text = objempleado.nit.ToString();
            txtDPI.Text = objempleado.dpi.ToString();
        }

        public void ShowNotification(string messaje)
        {
            label1.Visible = true;
            label1.Text = messaje.ToString();
        }

        public void HideButtom()
        {

            MakeVisible(false);

        }

        public void ShowButtom()
        {

            MakeVisible(true);

        }

        public void MakeVisible(Boolean showOrHide)
        {
            foreach (Control c in Controls)
            {
                c.Visible = showOrHide;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillEmpleado();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void radButton1_Click_1(object sender, EventArgs e)
        {
            int empleadoID = Convert.ToInt32(comboBox2.SelectedValue);
            string NITempleado = txtNIT.Text.ToString();
            string DPIempleado = txtDPI.Text.ToString();
            UpdateEmpleado(NITempleado, empleadoID, DPIempleado);
        }
    }
}
