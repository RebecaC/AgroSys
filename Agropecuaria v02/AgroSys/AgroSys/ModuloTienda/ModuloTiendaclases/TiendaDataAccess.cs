using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroSys
{
    class TiendaDataAccess
    {
        public  bool SetTienda(string nombre , string direccion, string telefono )
        {
            try
            {
                using (agrosysEntitiesFull TiendaEntidad = new agrosysEntitiesFull())
                {
                    tienda objTienda = new tienda();
                    objTienda.nombre = nombre;
                    objTienda.telefono = telefono;
                    objTienda.direccion = direccion;

                    TiendaEntidad.tiendas.Add(objTienda);
                    TiendaEntidad.SaveChanges();

                }
                return true;
            }
            catch (Exception)
            {
                return false;
                throw new Exception("Hay un problema al guardar la tienda, por favor intente de nuevo.");
            }

        }

        public object GetTienda(int id_tienda) 
        {
            tienda objTienda = new tienda();
            // Get tienda from DB
            using (agrosysEntitiesFull TiendaEntidad = new agrosysEntitiesFull())
            {
                objTienda = TiendaEntidad.tiendas.Where(s => s.id_tienda == id_tienda).FirstOrDefault<tienda>();
            }          
            return objTienda;
        }
    }
}
