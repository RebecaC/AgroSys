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
    public partial class EliminarEmpleados : Telerik.WinControls.UI.RadForm
    {
        public EliminarEmpleados()
        {
            InitializeComponent();
        }

        public static void DeleteEmpleados()
        {
            // Get Employes from DB
            using (var entityModel= new agrosysEntitiesFull ())
            {
                //employe = ctx.Teachers.Where(t => t.TeacherName == "Teacher 1").FirstOrDefault<Teacher>();
               
            }

        }
 
    }
}
