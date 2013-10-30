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
    public partial class ActualizarTienda : Telerik.WinControls.UI.RadForm
    {
        public ActualizarTienda()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
 
        }

        private void ActualizarTienda_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tienda.tienda' Puede moverla o quitarla según sea necesario.
            this.tiendaTableAdapter.Fill(this.tienda.tienda);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTienda();
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
            int tiendaID = Convert.ToInt32(comboBox1.SelectedValue);
            string nombreTienda = txtN.Text.ToString();
            UpdateTienda(nombreTienda,tiendaID);
           
        }

        public void UpdateTienda(string nombreTienda,int tiendaID) 
        {

            tienda objTienda = new tienda();
            tienda objTiendaVerificar = new tienda();


            using (agrosysEntitiesFull VerificarTiendaEntidad = new agrosysEntitiesFull())
            {
                objTiendaVerificar = VerificarTiendaEntidad.tiendas.Where(s => s.nombre == nombreTienda).FirstOrDefault<tienda>();
            }

            if (objTiendaVerificar == null)
            {
                using (agrosysEntitiesFull TiendaEntidad = new agrosysEntitiesFull())
                {
                    objTienda = TiendaEntidad.tiendas.Where(s => s.id_tienda == tiendaID).FirstOrDefault<tienda>();
                }

                objTienda.nombre = txtN.Text.ToString();
                objTienda.direccion = txtD.Text.ToString();
                objTienda.telefono = txtT.Text.ToString();

                using (agrosysEntitiesFull TiendaEntidad = new agrosysEntitiesFull())
                {
                    TiendaEntidad.Entry(objTienda).State = System.Data.EntityState.Modified;
                    TiendaEntidad.SaveChanges();
                }
                HideButtom();
                ShowNotification("Su registro a sido actualizado!");
            }
            else 
            {
                ShowNotification("Ya existe una tienda con ese nomnbre!");
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
        public void MakeVisible( Boolean showOrHide )
        {
            foreach ( Control c in Controls )
            {
                c.Visible = showOrHide;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
