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
    public partial class EliminarProveedores : Telerik.WinControls.UI.RadForm
    {
        public EliminarProveedores()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillProveedor();
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

        public void DeleteProveedores()
        {
            int idProveedor = Convert.ToInt32(comboBox1.SelectedValue);
            proveedor objTiendaVerificar = new proveedor();

            using (agrosysEntitiesFull VerificarTiendaEntidad = new agrosysEntitiesFull())
            {
                objTiendaVerificar = VerificarTiendaEntidad.proveedors.Where(s => s.id_proveedor == idProveedor).FirstOrDefault<proveedor>();
            }

            if (objTiendaVerificar != null)
            {
                using (agrosysEntitiesFull ProveedorEntidad = new agrosysEntitiesFull())
                {
                    objTiendaVerificar = ProveedorEntidad.proveedors.Where(s => s.id_proveedor == idProveedor).FirstOrDefault<proveedor>();
                    ProveedorEntidad.Set<proveedor>().Remove(objTiendaVerificar);
                    ProveedorEntidad.SaveChanges();
                }
                ShowNotification("Su registro a sido Eliminado!");
            }
            else
            {
                ShowNotification("El registro no Existe!");
            }

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

        private void EliminarProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedores.proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.proveedores.proveedor);

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            DeleteProveedores();
        }

    }
}
