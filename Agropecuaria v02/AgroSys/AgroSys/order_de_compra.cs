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
    
    public partial class order_de_compra
    {
        public order_de_compra()
        {
            this.detalle_order_de_compra = new HashSet<detalle_order_de_compra>();
        }
    
        public int id_order_de_compra { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<System.TimeSpan> hora { get; set; }
        public string iva { get; set; }
        public string total { get; set; }
    
        public virtual ICollection<detalle_order_de_compra> detalle_order_de_compra { get; set; }
    }
}
