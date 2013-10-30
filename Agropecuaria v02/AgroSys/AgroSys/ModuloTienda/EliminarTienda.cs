using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using AgroSys;
using System.Collections;

namespace AgroSys
{
    public partial class EliminarTienda : Telerik.WinControls.UI.RadForm
    {
        public EliminarTienda()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

     

        public void FillTienda()
        {

            tienda objTienda = new tienda();
            int tiendaID = Convert.ToInt32(comboBox1.SelectedValue);
            // Get tienda from DB
            using (agrosysEntitiesFull TiendaEntidad = new agrosysEntitiesFull())
            {
                objTienda = TiendaEntidad.tiendas.Where(s => s.id_tienda == tiendaID).FirstOrDefault<tienda>();
            }
            txtN.Text = objTienda.nombre.ToString();
            txtD.Text = objTienda.direccion.ToString();
            txtT.Text = objTienda.telefono.ToString();
        }
        private void radButton1_Click(object sender, EventArgs e)
        {


        }

        public void DeleteTienda()
        {

            tienda objTienda = new tienda();
            tienda objTiendaVerificar = new tienda();
            int tiendaID = Convert.ToInt32(comboBox1.SelectedValue);
            string nombreTienda = txtN.Text.ToString();

            using (agrosysEntitiesFull VerificarTiendaEntidad = new agrosysEntitiesFull())
            {
                objTiendaVerificar = VerificarTiendaEntidad.tiendas.Where(s => s.nombre == nombreTienda).FirstOrDefault<tienda>();
            }

            if (objTiendaVerificar != null)
            {
                using (agrosysEntitiesFull TiendaEntidad = new agrosysEntitiesFull())
                {
                    objTienda = TiendaEntidad.tiendas.Where(s => s.id_tienda == tiendaID).FirstOrDefault<tienda>();
                    TiendaEntidad.Set<tienda>().Remove(objTienda);
                    TiendaEntidad.SaveChanges();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EliminarTienda_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tienda.tienda' Puede moverla o quitarla según sea necesario.
            this.tiendaTableAdapter.Fill(this.tienda.tienda);

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
                        FillTienda();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DeleteTienda();

        }

    }
}
