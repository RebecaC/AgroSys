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
using System.Transactions;
using System.Data.Objects;

namespace AgroSys
{
    public partial class IngresoFacturas : Telerik.WinControls.UI.RadForm
    {
        public IngresoFacturas()
        {
            InitializeComponent();
        }

            DataSet ds = new DataSet();
            DataTable dt = new DataTable("dsDetalleFacturas");
           


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void IngresoFacturas_Load(object sender, EventArgs e)
        {
            dsSchema(ds);

            // TODO: esta línea de código carga datos en la tabla 'productos.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter1.Fill(this.productos.producto);
            // TODO: esta línea de código carga datos en la tabla 'agrosysDataSet4.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter1.Fill(this.agrosysDataSet4.cliente);
            // TODO: esta línea de código carga datos en la tabla 'agrosysDataSet8.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.agrosysDataSet8.cliente);
            // TODO: esta línea de código carga datos en la tabla 'productosFull.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.productosFull.producto);

        }
        public void beginTransaccion()
        {
            using (var scope = new System.Transactions.TransactionScope())
            { 
                
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearFields();
            var productoID = comboBox1.SelectedValue.ToString();
            fillProducto(productoID);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idCliente = Convert.ToInt16(comboBox2.SelectedValue.ToString());
            fillCliente(idCliente);
        }
        public void fillProducto(string idProducto) 
        {
            using (var dbContex = new agrosysEntitiesFull())
            {
                var results  = dbContex.getPrecioProductosPorID(idProducto);
                foreach (var item in results)
                {
                    txtDetallePrecio.Text = item.ToString();
                }
            }
        }
        public void fillCliente(int idCliente) 
        {
            using (var dbContex = new agrosysEntitiesFull()) 
            {
                var result = dbContex.getClientesPorID(idCliente);
              
                foreach (var item in result)
                {
                    txtCliente.Text = item.primer_nombre + " " + item.segundo_nombre + " " + item.primer_apellido + " " + item.segundo_apellido;
                }
            }
        }

        public void clearFields() 
        {
            txtDetalleCantidad.Text = "";
            txtDetalleSubtotal.Text = "";
        }
        private void txtDetalleCantidad_TextChanged(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(txtDetalleCantidad.Text ) == false)
            {
                int cantidad = Convert.ToInt32(txtDetalleCantidad.Text);
                double precio = Convert.ToDouble(txtDetallePrecio.Text);
                setSubtotal(cantidad, precio);
            }
           
        }

        public void setSubtotal(int cantidad, double precio) 
        {
            var total = cantidad * precio;
            txtDetalleSubtotal.Text = Convert.ToString( total );
        }

        public bool isNullTable() 
        {
            using (var dbContex = new agrosysEntitiesFull())
            {
                var result = dbContex.FacturaContador();
                var contador = "";
                foreach (var item in result)
                {
                     contador = item ; 
                }
                if ( Convert.ToInt16(contador) == 0)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            
        }

        public int getNextValue()
        {
            using (var dbContex = new agrosysEntitiesFull())
            {
                var result = dbContex.FacturaNextIdValue("facturas");
                var contador = "";
                foreach (var item in result)
                {
                    contador = item;
                }
                return Convert.ToInt16(contador);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFactura();    
            isNullTable();
            getNextValue();
        }
        public void saveFactura() 
        {
            try
            {
                var clienteID = Convert.ToInt16(comboBox2.SelectedValue.ToString());
                var subTotal = txtSubTotal.Text;
                var total = txtTotal.Text;
                var iva = txtIVA.Text;

                SetFactura(subTotal, total, iva, clienteID);
            }
            catch (Exception)
            {
                throw new Exception("Hay un problema al guardar el Empleado, por favor intente de nuevo.");
            }
        }

        public void ShowNotification(string messaje)
        {
             MessageBox.Show(messaje.ToString());
        }

        public void runTransaction() 
        {
            saveFactura();
            setDetalleFactura();
           
                   
        }

        public void SetFactura(string subTotal, string total, string iva, int clienteID) 
        {
            try
            {
                      using (agrosysEntitiesFull facturaEntidad = new agrosysEntitiesFull())
                    {
                            //se guarda la factura
                              factura objfactura = new factura();

                              objfactura.sub_total = subTotal;
                              objfactura.iva = iva;
                              objfactura.total = total;
                              objfactura.cliente_id_cliente = clienteID;
                              facturaEntidad.facturas.Add(objfactura);
                              facturaEntidad.SaveChanges();           
                           }                     
                

            }
            catch (Exception)
            {
                throw new Exception("Hay un problema al guardar la tienda, por favor intente de nuevo.");
            }
        }

        public void saveDetalleFactura()
        {
            try
            {
                var productoID = Convert.ToInt16(comboBox1.SelectedValue.ToString());
                var subTotal = txtDetalleSubtotal.Text;
                var cantidad = Convert.ToInt16(txtDetalleCantidad.Text);
                int facturaID = getNextValue()  ;

                setDSDetalleFactura(subTotal, cantidad,  facturaID, productoID);
            }
            catch (Exception)
            {
                throw new Exception("Hay un problema al guardar el Empleado, por favor intente de nuevo.");
            }
        }
        public void setDetalleFactura() 
        {
            try
            {

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                   {
                       using (agrosysEntitiesFull facturaEntidad = new agrosysEntitiesFull())
                        {
                            detalle_factura objDetalleFactura = new detalle_factura(); 
                            objDetalleFactura.cantidad = Convert.ToInt32(ds.Tables[0].Rows[i]["cantidad"]);
                            objDetalleFactura.sub_total = ds.Tables[0].Rows[i]["subTotal"].ToString();
                            objDetalleFactura.factura_id_factura = Convert.ToInt32(ds.Tables[0].Rows[i]["facturaID"]);
                            objDetalleFactura.producto_id_producto = Convert.ToInt32(ds.Tables[0].Rows[i]["productoID"]);
                            facturaEntidad.detalle_factura.Add(objDetalleFactura);
                            facturaEntidad.SaveChanges();
                        }
                    }
               
            }
            catch (Exception)
            {
                
                throw new Exception("Hay un problema al guardar la factura, por favor intente de nuevo.");
            }
        }

        public DataSet setDSDetalleFactura(string subTotal, int cantidad, int facturaID, int productoID)
        {
           

            dt.Rows.Add(subTotal, cantidad, facturaID, productoID);

            return ds;

        }
        public DataSet dsSchema( DataSet ds) 
        {
            ds.Tables.Add(dt);
            dt.Columns.Add("subTotal", typeof(string));
            dt.Columns.Add("cantidad", typeof(string));
            dt.Columns.Add("facturaID", typeof(string));
            dt.Columns.Add("productoID", typeof(string));
            return ds;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveDetalleFactura();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            runTransaction();
        }
    }
}
