﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class agrosysEntitiesFull : DbContext
    {
        public agrosysEntitiesFull()
            : base("name=agrosysEntitiesFull")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<cliente> clientes { get; set; }
        public DbSet<control_acceso> control_acceso { get; set; }
        public DbSet<detalle_order_de_compra> detalle_order_de_compra { get; set; }
        public DbSet<detalle_pedido_tienda> detalle_pedido_tienda { get; set; }
        public DbSet<empleado> empleadoes { get; set; }
        public DbSet<envio_tienda> envio_tienda { get; set; }
        public DbSet<inventario> inventarios { get; set; }
        public DbSet<order_de_compra> order_de_compra { get; set; }
        public DbSet<pedido_cliente> pedido_cliente { get; set; }
        public DbSet<pedido_tienda> pedido_tienda { get; set; }
        public DbSet<producto> productoes { get; set; }
        public DbSet<proveedor> proveedors { get; set; }
        public DbSet<rol> rols { get; set; }
        public DbSet<tienda> tiendas { get; set; }
        public DbSet<usuario> usuarios { get; set; }
        public DbSet<factura> facturas { get; set; }
        public DbSet<detalle_factura> detalle_factura { get; set; }
    
        public virtual ObjectResult<getClientes_Result> getClientes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getClientes_Result>("getClientes");
        }
    
        public virtual ObjectResult<getClientesById_Result> getClientesById(Nullable<int> clienteId)
        {
            var clienteIdParameter = clienteId.HasValue ?
                new ObjectParameter("clienteId", clienteId) :
                new ObjectParameter("clienteId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getClientesById_Result>("getClientesById", clienteIdParameter);
        }
    
        public virtual ObjectResult<cliente> getClientesModel()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<cliente>("getClientesModel");
        }
    
        public virtual ObjectResult<cliente> getClientesModel(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<cliente>("getClientesModel", mergeOption);
        }
    
        public virtual int obtenerClientes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("obtenerClientes");
        }
    
        public virtual ObjectResult<cliente> getClientesPorID(Nullable<int> clienteId)
        {
            var clienteIdParameter = clienteId.HasValue ?
                new ObjectParameter("clienteId", clienteId) :
                new ObjectParameter("clienteId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<cliente>("getClientesPorID", clienteIdParameter);
        }
    
        public virtual ObjectResult<cliente> getClientesPorID(Nullable<int> clienteId, MergeOption mergeOption)
        {
            var clienteIdParameter = clienteId.HasValue ?
                new ObjectParameter("clienteId", clienteId) :
                new ObjectParameter("clienteId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<cliente>("getClientesPorID", mergeOption, clienteIdParameter);
        }
    
        public virtual ObjectResult<string> getPrecioProductosPorID(string productoID)
        {
            var productoIDParameter = productoID != null ?
                new ObjectParameter("productoID", productoID) :
                new ObjectParameter("productoID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("getPrecioProductosPorID", productoIDParameter);
        }
    
        public virtual ObjectResult<string> FacturaContador()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("FacturaContador");
        }
    
        public virtual ObjectResult<string> FacturaNextIdValue(string tableName)
        {
            var tableNameParameter = tableName != null ?
                new ObjectParameter("tableName", tableName) :
                new ObjectParameter("tableName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("FacturaNextIdValue", tableNameParameter);
        }
    }
}
