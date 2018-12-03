using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataModel
{
    public partial class BdModel : DbContext
    {
        //Agregamos una conexion a una BD y le en Catalog definimos el nombre de la BD con el que se va a crear
        public BdModel() : base(@"Data Source=LAPTOP-JK4B87S3;Initial Catalog=Joel;Integrated Security=True") { }

        //Agregamos nuestras clases y las relaciones
        public DbSet<ClsClienteEntity> ClientesEntities { get; set; }
        public DbSet<ClsCompraEntity> ComprasEntities { get; set; }

    }


    public partial class BdModel
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Se utiliza para agregar las configuraciones
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();

            //Agregamos las cnfiguraciones que hicimos en el Mepao de cada una de las tablas 
            //y se manda a llamar por el nombre que se e definio a la configuracion de cada clase
            modelBuilder.Configurations.Add(new ClsClienteEntityMapping());
            modelBuilder.Configurations.Add(new ClsCompraEntityMapping());

            //Se manda una coleccion o un conjunto de datos agrupados en un solo paquete esto quiere decir
            //  que modelBuilder guarda todas las configuraciones de cada una de las clases readas
            base.OnModelCreating(modelBuilder);
        }
    }
}


