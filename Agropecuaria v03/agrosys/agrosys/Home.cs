using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using AgroSys.ModuloEmpleados;
using AgroSys.ModuloFacturas;
using AgroSys;

namespace AgroSys
{
    public partial class Home : Telerik.WinControls.UI.RadForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
         
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClientesHome cli = new ClientesHome();
            cli.Show();
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            ProveedoresHome prove = new ProveedoresHome();
            prove.Show();
        }

        private void radMenuItem3_Click_1(object sender, EventArgs e)
        {
            EmpleadosHome emple = new EmpleadosHome();
            emple.Show();
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            ProductosHome prod = new ProductosHome();
            prod.Show();
        }

        

        private void radMenuItem8_Click(object sender, EventArgs e)
        {
            FacturasHome fac = new FacturasHome();
            fac.Show();
        }

        private void radMenuItem9_Click(object sender, EventArgs e)
        {
            TiendaHome ing = new TiendaHome();
            ing.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

        private void radMenuItem11_Click(object sender, EventArgs e)
        {
            ListarRolUsuario lista = new ListarRolUsuario();
            lista.Show();
        }

        private void radMenuItem13_Click(object sender, EventArgs e)
        {
           
        }

        private void radMenuItem8_Click_1(object sender, EventArgs e)
        {
            FacturasHome fh = new FacturasHome();
            fh.Show();
        }

    }
}
