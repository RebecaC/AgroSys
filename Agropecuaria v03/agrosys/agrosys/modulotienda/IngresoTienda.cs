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
    public partial class IngresoTienda : Telerik.WinControls.UI.RadForm
    {
        public IngresoTienda()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        public void ShowNotification(string messaje)
        {
            lblMsj.Visible = true;
            lblMsj.Text = messaje.ToString();
        }
        public void SaveTienda()
        {
            try
            {
   
                var nombre = txtNombre.Text.ToString();
                var telefono = txtTelefono.Text.ToString();
                var direccion = txtDireccion.Text.ToString();


              SetTienda(nombre, direccion, telefono);

            }
            catch (Exception)
            {
                throw new Exception("Hay un problema al guardar la tienda, por favor intente de nuevo.");
            }
           
        }
        public void SetTienda(string nombre, string direccion, string telefono)
        {
            try
            {
                tienda objTiendaVerificar = new tienda();
                using (agrosysEntitiesFull VerificarTiendaEntidad = new agrosysEntitiesFull())
                {
                    objTiendaVerificar = VerificarTiendaEntidad.tiendas.Where(s => s.nombre == nombre).FirstOrDefault<tienda>();
                }

                 if (objTiendaVerificar == null)
                 {
                     using (agrosysEntitiesFull TiendaEntidad = new agrosysEntitiesFull())
                     {
                         tienda objTienda = new tienda();
                         objTienda.nombre = nombre;
                         objTienda.telefono = telefono;
                         objTienda.direccion = direccion;

                         TiendaEntidad.tiendas.Add(objTienda);
                         TiendaEntidad.SaveChanges();
                         string mensaje = "La tienda con el nombre " + nombre + " a sido guardada";
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

      
        private void IngresoTienda_Load(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            SaveTienda();
        }
    }
}
