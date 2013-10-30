using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

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
            Clientes cli = new Clientes();
            cli.Show();
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            Proveedores prove = new Proveedores();
            prove.Show();
        }
    }
}
