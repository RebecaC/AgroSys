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
    public partial class ActualizarProveedor : Telerik.WinControls.UI.RadForm
    {
        public ActualizarProveedor()
        {
            InitializeComponent();
        }
        public void UpdateProveedor(string NITproveedor, int proveedorID)
        {

            proveedor objProveedor = new proveedor();
            proveedor objProveedorVerificar = new proveedor();

            using (agrosysEntitiesFull VerificarProveedorEntidad = new agrosysEntitiesFull())
            {
                objProveedorVerificar = VerificarProveedorEntidad.proveedors
                    .Where(s => s.id_proveedor != proveedorID || s.nit == NITproveedor )
                    .FirstOrDefault<proveedor>();
            }
            if (objProveedorVerificar == null)
            {
                using (agrosysEntitiesFull proveedorEntidad = new agrosysEntitiesFull())
                {
                    objProveedor = proveedorEntidad.proveedors.Where(s => s.id_proveedor == proveedorID).FirstOrDefault<proveedor>();
                }

                objProveedor.nombre_proveedor = txtN.Text.ToString();
                objProveedor.telefono = txtT.Text.ToString();
                objProveedor.nit = txtNIT.Text.ToString();
                objProveedor.direccion = txtD.Text.ToString();

                using (agrosysEntitiesFull proveedorEntidad = new agrosysEntitiesFull())
                {
                    proveedorEntidad.Entry(objProveedor).State = System.Data.EntityState.Modified;
                    proveedorEntidad.SaveChanges();
                }
                
               ShowNotification("Su registro a sido actualizado!");
            }
            else
            {
                ShowNotification("Ya existe proveedor  con ese NIT!");
            }

        }


        public void FillProveedor()
        {

            proveedor objproveedor = new proveedor();
            int proveedorID = Convert.ToInt32(comboBox1.SelectedValue);
            // Get tienda from DB
            using (agrosysEntitiesFull proveedorEntidad = new agrosysEntitiesFull())
            {
                objproveedor = proveedorEntidad.proveedors.Where(s => s.id_proveedor == proveedorID).FirstOrDefault<proveedor>();
            }
            txtN.Text = objproveedor.nombre_proveedor.ToString();
            txtD.Text = objproveedor.direccion.ToString();
            txtT.Text = objproveedor.telefono.ToString();
            txtNIT.Text = objproveedor.nit.ToString();
        }

        public void ShowNotification(string messaje)
        {
            MessageBox.Show(messaje.ToString());
        }
        public void CleanInputs()
        {
            txtN.Text = "";
            txtD.Text = "";
            txtNIT.Text = "";
            txtT.Text = "";
        }

        private void ActualizarProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedores.proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.proveedores.proveedor);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillProveedor();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            var nit = txtNIT.Text.ToString();
            var proveedorID = Convert.ToInt16(comboBox1.SelectedValue);
            UpdateProveedor(nit, proveedorID);
        }
    }
}
