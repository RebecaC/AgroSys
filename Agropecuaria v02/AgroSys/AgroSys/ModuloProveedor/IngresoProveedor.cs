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
    public partial class IngresoProveedor : Telerik.WinControls.UI.RadForm
    {
        public IngresoProveedor()
        {
            InitializeComponent();
        }
        public void ShowNotification(string messaje)
        {
            MessageBox.Show( messaje.ToString());
        }
        public void SaveProveedores()
        {
            try
            {

                var nombre = txtN.Text.ToString();
                var telefono = txtT.Text.ToString();
                var direccion = txtD.Text.ToString();
                var nit = txtNIT.Text.ToString();

                SetProveedores(nombre, direccion, telefono, nit);

            }
            catch (Exception)
            {
                throw new Exception("Hay un problema al guardar el proveedor, por favor intente de nuevo.");
            }

        }
        public void SetProveedores(string nombre, string direccion, string telefono, string nit)
        {
            try
            {
                proveedor objProveedorVerificar = new proveedor();
                using (agrosysEntitiesFull VerificarProveedorEntidad = new agrosysEntitiesFull())
                {
                    objProveedorVerificar = VerificarProveedorEntidad.proveedors.Where(s => s.nombre_proveedor == nombre || s.nit == nit).FirstOrDefault<proveedor>();
                }

                if (objProveedorVerificar == null)
                {
                    using (agrosysEntitiesFull ProveedorEntidad = new agrosysEntitiesFull())
                    {
                        proveedor objProveedor = new proveedor();

                        objProveedor.nombre_proveedor = nombre;
                        objProveedor.nit = nit;
                        objProveedor.telefono = telefono;
                        objProveedor.direccion = direccion;
                        ProveedorEntidad.proveedors.Add(objProveedor);
                        ProveedorEntidad.SaveChanges();
                        string mensaje = "El proveedor con el NIT " + nit + " a sido guardado";
                        ShowNotification(mensaje);
                        CleanInputs();
                    }
                }
                else
                {
                    ShowNotification("No se a podido guardar el registro");
                }

            }
            catch (Exception)
            {
                throw new Exception("Hay un problema al guardar la Proveedor, por favor intente de nuevo.");
            }

        }

        public  void CleanInputs()
        {
            txtN.Text="";
            txtD.Text="";
            txtNIT.Text="";
            txtT.Text="";
        }
        private void radButton1_Click(object sender, EventArgs e)
        {
            SaveProveedores();
        }
       
    }
}
