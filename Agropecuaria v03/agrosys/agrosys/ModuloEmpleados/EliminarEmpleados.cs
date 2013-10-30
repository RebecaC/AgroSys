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
    public partial class EliminarEmpleados : Telerik.WinControls.UI.RadForm
    {
        public EliminarEmpleados()
        {
            InitializeComponent();
        }

        
       public void Fillempleado()
        {

            empleado objempleado = new empleado();
            int empleadoID = Convert.ToInt32(comboBox1.SelectedValue);
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

        public void DeleteEmpleados()
        {
           int  idempleado = Convert.ToInt32( comboBox1.SelectedValue);
           empleado objTiendaVerificar = new empleado();
           
            using (agrosysEntitiesFull VerificarTiendaEntidad = new agrosysEntitiesFull())
            {
                objTiendaVerificar = VerificarTiendaEntidad.empleadoes.Where(s => s.id_empleado == idempleado).FirstOrDefault<empleado>();
            }

            if (objTiendaVerificar != null)
            {
                using (agrosysEntitiesFull empleadoEntidad = new agrosysEntitiesFull())
                {
                    objTiendaVerificar = empleadoEntidad.empleadoes.Where(s => s.id_empleado == idempleado).FirstOrDefault<empleado>();
                    empleadoEntidad.Set<empleado>().Remove(objTiendaVerificar);
                    empleadoEntidad.SaveChanges();
                }

                HideButtom();
                ShowNotification("Su registro a sido Eliminado!");
            }
            else
            {
                ShowNotification("El registro no Existe!");
            }

        }

        public void ShowNotification(string messaje)
        {
            MessageBox.Show( messaje.ToString() );
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

        private void EliminarEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agrosysDataSet6.empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.agrosysDataSet6.empleado);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fillempleado();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            DeleteEmpleados();
        }

        
 
    }
}
