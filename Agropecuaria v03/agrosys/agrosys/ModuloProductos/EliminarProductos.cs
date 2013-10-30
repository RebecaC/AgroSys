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
    public partial class EliminarProductos : Telerik.WinControls.UI.RadForm
    {
        public EliminarProductos()
        {
            InitializeComponent();
        }

        private void EliminarProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedor.proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.proveedor.proveedor);
            // TODO: esta línea de código carga datos en la tabla 'productos.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.productos.producto);

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
        public void DeleteProductos()
        {
            int idProductos = Convert.ToInt32(comboBox2.SelectedValue);
            producto objTiendaVerificar = new producto();

            using (agrosysEntitiesFull VerificarTiendaEntidad = new agrosysEntitiesFull())
            {
                objTiendaVerificar = VerificarTiendaEntidad.productoes.Where(s => s.id_producto == idProductos).FirstOrDefault<producto>();
            }

            if (objTiendaVerificar != null)
            {
                using (agrosysEntitiesFull ProveedorEntidad = new agrosysEntitiesFull())
                {
                    objTiendaVerificar = ProveedorEntidad.productoes.Where(s => s.id_producto == idProductos).FirstOrDefault<producto>();
                    ProveedorEntidad.Set<producto>().Remove(objTiendaVerificar);
                    ProveedorEntidad.SaveChanges();
                }
                ShowNotification("Su registro a sido Eliminado!");
                HideButtom();
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
            FillProducto();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            DeleteProductos();
        }
    }
}
