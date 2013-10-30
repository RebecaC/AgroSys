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
    public partial class IngresoClientes : Telerik.WinControls.UI.RadForm
    {
        public IngresoClientes()
        {
            InitializeComponent();
        }
        
        private void radLabel2_Click(object sender, EventArgs e)
        {

        }

        private void radLabel8_Click(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            SaveClientes();
        }
        public void ShowNotification(string messaje)
        {
            lblMsj.Visible = true;
            lblMsj.Text = messaje.ToString();
        }
        public void SaveClientes()
        {
            try
            {

                var primerNombre = txtN.Text.ToString();
                var segundoNombre = txtN2.Text.ToString();
                var primerApellido = txtA.Text.ToString();
                var segundoApellido = txtA2.Text.ToString();
                var telefono =  txtT.Text.ToString();
                var direccion = txtD.Text.ToString();
                var nit = txtNIT.Text.ToString();
                var dpi = txtDPI.Text.ToString();

                SetClientes(primerNombre, segundoNombre, primerApellido, segundoApellido, telefono, direccion, nit,dpi);

            }
            catch (Exception)
            {
                throw new Exception("Hay un problema al guardar el Cliente, por favor intente de nuevo.");
            }

        }
        public void SetClientes(string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string telefono, string direccion,string nit , string dpi)
        {
            try
            {
                cliente objTiendaVerificar = new cliente();
                using (agrosysEntitiesFull VerificarTiendaEntidad = new agrosysEntitiesFull())
                {
                    objTiendaVerificar = VerificarTiendaEntidad.clientes.Where(s => s.nit == nit).FirstOrDefault<cliente>();
                }

                if (objTiendaVerificar == null)
                {
                    using (agrosysEntitiesFull TiendaEntidad = new agrosysEntitiesFull())
                    {
                        cliente objCliente = new cliente();

                        objCliente.primer_nombre = primerNombre;
                        objCliente.segundo_nombre = segundoNombre;
                        objCliente.primer_apellido = primerApellido;
                        objCliente.segundo_apellido = segundoApellido;
                        objCliente.nit = nit;
                        objCliente.telefono = telefono;
                        objCliente.direccion = direccion;
                        objCliente.dpi = dpi;

                        TiendaEntidad.clientes.Add(objCliente);
                        TiendaEntidad.SaveChanges();
                        string mensaje = "El cliente con el NIT " + nit + " a sido guardado";
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

        private void IngresoClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
