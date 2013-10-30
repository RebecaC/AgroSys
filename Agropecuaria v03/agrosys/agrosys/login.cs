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
    public partial class login : Telerik.WinControls.UI.RadForm
    {
        public login()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Home ho = new Home();
            ho.Show();
        }
    }
}
