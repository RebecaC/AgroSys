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
    public partial class ActualizarClientes : Telerik.WinControls.UI.RadForm
    {
        public ActualizarClientes()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            int clienteID = Convert.ToInt32(comboBox1.SelectedValue);
            string NITCliente = txtNIT.Text.ToString();
            string DPICliente = txtDPI.Text.ToString();
            UpdateCliente(NITCliente, clienteID, DPICliente);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCliente();
        }

        public void UpdateCliente(string NITCliente, int clienteID, string dpi)
        {

            cliente objCliente= new cliente();
            cliente objTiendaVerificar = new cliente();


            using (agrosysEntitiesFull VerificarTiendaEntidad = new agrosysEntitiesFull())
            {
                objTiendaVerificar = VerificarTiendaEntidad.clientes
                    .Where(s => s.id_cliente != clienteID &&( s.nit == NITCliente || s.dpi == dpi))
                    .FirstOrDefault<cliente>();
            }
            if (objTiendaVerificar == null)
            {
                using (agrosysEntitiesFull ClienteEntidad = new agrosysEntitiesFull())
                {
                    objCliente = ClienteEntidad.clientes.Where(s => s.id_cliente == clienteID).FirstOrDefault<cliente>();
                }

                objCliente.primer_nombre = txtN.Text.ToString();
                objCliente.segundo_nombre = txtN2.Text.ToString();
                objCliente.primer_apellido = txtA.Text.ToString();
                objCliente.segundo_apellido = txtA2.Text.ToString();
                objCliente.telefono = txtT.Text.ToString();
                objCliente.nit = txtNIT.Text.ToString();
                objCliente.direccion = txtNIT.Text.ToString();
                objCliente.dpi = txtDPI.Text.ToString();

                using (agrosysEntitiesFull ClienteEntidad = new agrosysEntitiesFull())
                {
                    ClienteEntidad.Entry(objCliente).State = System.Data.EntityState.Modified;
                    ClienteEntidad.SaveChanges();
                }
                HideButtom();
                ShowNotification("Su registro a sido actualizado!");
            }
            else
            {
                ShowNotification("Ya existe cliente  con ese NIT!");
            }

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

        private void ActualizarClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tienda.tienda' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'agrosysDataSet4.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.agrosysDataSet4.cliente);

        }

    }
}
