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
    public partial class IngresoProducto : Telerik.WinControls.UI.RadForm
    {
        public IngresoProducto()
        {
            InitializeComponent();
        }
        public void SaveProductos()
        {
            try
            {

                var nombre = txtN.Text.ToString();
                var detalle = txtD.Text.ToString();
                var precio = txtP.Text.ToString();
                var proveedorID = Convert.ToInt16( comboBox1.SelectedValue.ToString() );
                SetProductos(nombre, detalle,precio, proveedorID);

            }
            catch (Exception)
            {
                throw new Exception("Hay un problema al guardar el Producto, por favor intente de nuevo.");
            }

        }
        public void SetProductos(string nombre, string detalle,string precio, int proveedorID)
        {
            try
            {
                producto objTiendaVerificar = new producto();
                using (agrosysEntitiesFull VerificarTiendaEntidad = new agrosysEntitiesFull())
                {
                    objTiendaVerificar = VerificarTiendaEntidad.productoes.Where(s => s.nombre_producto == nombre).FirstOrDefault<producto>();
                }

                if (objTiendaVerificar == null)
                {
                    using (agrosysEntitiesFull TiendaEntidad = new agrosysEntitiesFull())
                    {
                        producto objProducto = new producto();

                        objProducto.nombre_producto = nombre;
                        objProducto.precio = precio;
                        objProducto.detalle_producto = detalle;
                        objProducto.proveedor_id_proveedor = proveedorID;                     

                        TiendaEntidad.productoes.Add(objProducto);
                        TiendaEntidad.SaveChanges();
                        string mensaje = "El Producto con el Nombre " + nombre + " a sido guardado";
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

        public void ShowNotification(string messaje)
        {
           MessageBox.Show( messaje.ToString() );
        }

        private void IngresoProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedor.proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.proveedor.proveedor);

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            SaveProductos();
        }
    }
}
