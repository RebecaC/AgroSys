//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgroSys
{
    using System;
    using System.Collections.Generic;
    
    public partial class factura
    {
        public int id_factura { get; set; }
        public string sub_total { get; set; }
        public string total { get; set; }
        public string iva { get; set; }
        public int cliente_id_cliente { get; set; }
    
        public virtual cliente cliente { get; set; }
    }
}
