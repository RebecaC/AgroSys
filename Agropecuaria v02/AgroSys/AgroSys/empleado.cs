//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgroSys
{
    using System;
    using System.Collections.Generic;
    
    public partial class empleado
    {
        public int id_empleado { get; set; }
        public string primer_nombre { get; set; }
        public string segundo_nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public int tienda_id_tienda { get; set; }
        public string dpi { get; set; }
        public string nit { get; set; }
    
        public virtual tienda tienda { get; set; }
    }
}