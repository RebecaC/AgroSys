using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgroSys
{
    class AccesoADatoscs
    {
         public static void Select()
        {
            using( var db = new agrosysEntitiesFull ())
            {
                db.clientes.Where(
            }
        }
    }
}
