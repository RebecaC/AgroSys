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
    public partial class EliminarClientes : Telerik.WinControls.UI.RadForm
    {
        public EliminarClientes()
        {
            InitializeComponent();
        }
        public void FillCliente()
        {

            cliente objCliente = new cliente();
            int clienteID = Convert.ToInt32(comboBox1.SelectedValue);
            // Get tienda from DB
            using (agrosysEntitiesFull ClienteEntidad = new agrosysEntitiesFull())
            {
                objCliente = ClienteEntidad.clientes.Where(s => s.id_cliente == clienteID).FirstOrDefault<cliente>();
            }
            txtN.Text = objCliente.primer_nombre.ToString();
            txtN2.Text = objCliente.segundo_nombre.ToString();
            txtA.Text = objCliente.primer_apellido.ToString();
            txtA2.Text = objCliente.segundo_apellido.ToString();
            txtD.Text = objCliente.direccion.ToString();
            txtT.Text = objCliente.telefono.ToString();
            txtNIT.Text = objCliente.nit.ToString();
            txtDPI.Text = objCliente.dpi.ToString();
        }

        public void DeleteClientes()
        {
           int  idCliente = Convert.ToInt32( comboBox1.SelectedValue);
           cliente objTiendaVerificar = new cliente();
           
            using (agrosysEntitiesFull VerificarTiendaEntidad = new agrosysEntitiesFull())
            {
                objTiendaVerificar = VerificarTiendaEntidad.clientes.Where(s => s.id_cliente == idCliente).FirstOrDefault<cliente>();
            }

            if (objTiendaVerificar != null)
            {
                using (agrosysEntitiesFull ClienteEntidad = new agrosysEntitiesFull())
                {
                    objTiendaVerificar = ClienteEntidad.clientes.Where(s => s.id_cliente == idCliente).FirstOrDefault<cliente>();
                    ClienteEntidad.Set<cliente>().Remove(objTiendaVerificar);
                    ClienteEntidad.SaveChanges();
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

        private void EliminarClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedores.proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.proveedores.proveedor);
            // TODO: esta línea de código carga datos en la tabla 'agrosysDataSet4.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.agrosysDataSet4.cliente);

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            DeleteClientes();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCliente();
        }
    }
}
