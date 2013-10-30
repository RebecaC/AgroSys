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
    public partial class ActualizarProducto : Telerik.WinControls.UI.RadForm
    {
        public ActualizarProducto()
        {
            InitializeComponent();
        }
      

        private void ActualizarProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productos.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.productos.producto);
            // TODO: esta línea de código carga datos en la tabla 'proveedor.proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.proveedor.proveedor);

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            var nombre = txtN.Text.ToString();
            var detalle = txtD.Text.ToString();
            var precio = txtP.Text.ToString();
            var proveedorID = Convert.ToInt16(comboBox1.SelectedValue.ToString());
            var productoID = Convert.ToInt16( comboBox2.SelectedValue.ToString() );
            UpdateProducto(nombre,detalle,precio,productoID,proveedorID);
        }
        public void UpdateProducto(string nombre, string detalle, string precio,  int productoID, int proveedorID)
        {

            producto objproducto = new producto();
            producto objTiendaVerificar = new producto();


            using (agrosysEntitiesFull VerificarTiendaEntidad = new agrosysEntitiesFull())
            {
                objTiendaVerificar = VerificarTiendaEntidad.productoes
                    .Where(s => s.id_producto != productoID && (s.nombre_producto == nombre ))
                    .FirstOrDefault<producto>();
            }
            if (objTiendaVerificar == null)
            {
                using (agrosysEntitiesFull productoEntidad = new agrosysEntitiesFull())
                {
                    objproducto = productoEntidad.productoes.Where(s => s.id_producto == productoID).FirstOrDefault<producto>();
                }
                int tiendaId = Convert.ToInt32(comboBox1.SelectedValue);
                objproducto.nombre_producto = nombre;
                objproducto.precio = precio;
                objproducto.detalle_producto = detalle;
                objproducto.proveedor_id_proveedor = proveedorID;


                using (agrosysEntitiesFull productoEntidad = new agrosysEntitiesFull())
                {
                    productoEntidad.Entry(objproducto).State = System.Data.EntityState.Modified;
                    productoEntidad.Entry(objproducto.proveedor).State = System.Data.EntityState.Modified;
                    productoEntidad.SaveChanges();
                }
                HideButtom();
                ShowNotification("Su registro a sido actualizado!");
            }
            else
            {
                ShowNotification("Ya existe producto  con ese Nombre!");
            }

        }

        public void FillProducto()
        {

            producto objproducto = new producto();
            int productoID = Convert.ToInt32(comboBox2.SelectedValue);
            // Get tienda from DB
            using (agrosysEntitiesFull productoEntidad = new agrosysEntitiesFull())
            {
                objproducto = productoEntidad.productoes.Where(s => s.id_producto == productoID).FirstOrDefault<producto>();
            }
            txtN.Text = objproducto.nombre_producto.ToString();
            txtD.Text = objproducto.detalle_producto.ToString();
            txtP.Text = objproducto.precio.ToString();
          
        }

        public void ShowNotification(string messaje)
        {
            MessageBox.Show(messaje.ToString());
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
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FillProducto();
        }
    }
}
