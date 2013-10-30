using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using AgroSys.ModuloEmpleados;

namespace AgroSys
{
    public partial class EmpleadosHome : Telerik.WinControls.UI.RadForm
    {
        public EmpleadosHome()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActualizarEmpleados actualiza = new ActualizarEmpleados();
            actualiza.Show();
            
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EliminarEmpleados elimina = new EliminarEmpleados();
            elimina.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IngresoEmpleados ingresa = new IngresoEmpleados();
            ingresa.Show();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListarEmpleados lista = new ListarEmpleados();
            lista.Show();
        }
    }
}
