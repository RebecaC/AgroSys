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
    
    public partial class rol
    {
        public rol()
        {
            this.usuarios = new HashSet<usuario>();
        }
    
        public int id_rol { get; set; }
        public string nombre_rol { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
    
        public virtual ICollection<usuario> usuarios { get; set; }
    }
}
