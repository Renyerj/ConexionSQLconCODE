using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace CNegocio
{
    public class PersonRule
    {
        //Agregamos nuestro modelo de datos par acceder a las tablas
        //Creamos un metodo para guardar
        public Guid GuardarClientes(ClsClienteEntity Cliente)
        {
            //Creamos una variable de BdModel
            using (var db = new BdModel())
            {
                try
                {
                    //Mandamos a crear el id
                    Cliente.ClienteId = Guid.NewGuid();
                    //Aregamos una coleccion de datos que los pasan el los formularios
                    db.ClientesEntities.Add(Cliente);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    e.ToString(); ;
                }
                return Cliente.ClienteId;
            }

        }
        //Consulta para listar cliente

       public List<ClsClienteEntity> ListarClientes(string Nombres)
        {
            using (var db = new BdModel())
            {
                //Acemos una conuslta donde el cliente sea igual a nombres listarlo a filtrarlo
                var Cliente = (from c in db.ClientesEntities where (c.Nombres).StartsWith(Nombres) select c).ToList();
                //retornamos cambios
                return Cliente;
            }
        }

        public void ActualizarClientes(ClsClienteEntity Cliente)
        {
            using (var db = new BdModel())
            {
                var p = db.ClientesEntities.Where(c => c.ClienteId == Cliente.ClienteId).FirstOrDefault();

                if (p != null)
                {
                    p.Nombres = Cliente.Nombres;
                    p.Apellidos = Cliente.Apellidos;
                    p.Telefono = Cliente.Telefono;
                    p.Direccion = Cliente.Direccion;

                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        //consulta elimianr cliente
        public void EliminarClientes(ClsClienteEntity Cliente)
        {

            using (var db = new BdModel())
            {
                //verificamos si el cliente es igual al que le pasamos por parametro si es igual
                var p = db.ClientesEntities.Where(c => c.ClienteId == Cliente.ClienteId).FirstOrDefault();
                //y el dato es diferente de null significa que existe un registro
                if (p != null)
                {
                    //se espesifica lo que realizara en este caso es Deleted para eliminar si fuera modificar o actulizar seria Modefied
                    db.Entry(p).State = System.Data.Entity.EntityState.Deleted;
                    //Mandamo a guardar todos los cambios
                    db.SaveChanges();
                }
            }
        }

        //Metodos de la tabla de Compras

        public Guid GuardarCompras(ClsCompraEntity Compras)
        {
            using (var db = new BdModel())
            {
                try
                {
                    Compras.CompraId = Guid.NewGuid();
                    db.ComprasEntities.Add(Compras);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    e.ToString(); ;
                }
                return Compras.CompraId;
            }

        }

        public void ActualizarCompras(ClsCompraEntity Compras)
        {
            using (var db = new BdModel())
            {
                var p = db.ComprasEntities.Where(c => c.CompraId == Compras.CompraId).FirstOrDefault();

                if (p != null)
                {
                    p.CompraId = Compras.CompraId;
                    p.Descripcion = Compras.Descripcion;
                    p.Cantidad = Compras.Cantidad;
                    p.Precio = Compras.Precio;

                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        public void EliminarCompras(ClsCompraEntity Compras)
        {

            using (var db = new BdModel())
            {
               
                var p = db.ComprasEntities.Where(c => c.CompraId == Compras.CompraId).FirstOrDefault();

                if (p != null)
                {
                    db.Entry(p).State = System.Data.Entity.EntityState.Deleted;
                    //Mandamo a guardar todos los cambios
                    db.SaveChanges();
                }
            }
        }

        public List<ClsCompraEntity> ListarCompras(string Descripcion)
        {
            using (var db = new BdModel())
            {
                //Acemos una conuslta donde el cliente sea igual a nombres listarlo a filtrarlo
                var Compras = (from c in db.ComprasEntities where (c.Descripcion).StartsWith(Descripcion) select c).ToList();
                //retornamos cambios
                return Compras;
            }
        }

    }
}
