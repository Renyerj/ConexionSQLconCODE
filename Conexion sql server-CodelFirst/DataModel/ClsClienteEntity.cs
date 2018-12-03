using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregamos una referencia EntityFrameword para reaizar la configuracion o mapeo de mi tabla 
//y espesificar tipos de datos etc
using System.Data.Entity.ModelConfiguration;

namespace DataModel
{
    //Creamos nuestra clase que en BD sera una tabla
    public partial class ClsClienteEntity
    {
        //Utilizamos guid para el Id de cliente es un tipo de dato que se autogenerara y puede contener numeros y caracteres
        //Definimos el tipo de dato
        public Guid ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }

    public partial class ClsClienteEntity
    {
        //Creamos una relacion
        public ClsClienteEntity()
        {
            this.ClientesEntities = new HashSet<ClsCompraEntity>();
        }
        //Realizamos un coleccion donde decimos que es una relacion de uno a muchos
        // el cual decimos que un cliente puede tener muchas compras
        //espesificamos la tabla con la relacion de uno
        //y en la coleccion la tabal que contendran el conjunto de datos o tratarlo como el lado de muchos

        public virtual ICollection<ClsCompraEntity> ClientesEntities { get; set; }

    }

    //Definimos el nombre de nuestro mapeo o configuracion de la tabla
    public class ClsClienteEntityMapping : EntityTypeConfiguration<ClsClienteEntity>
    {
        public ClsClienteEntityMapping()
        {
            //Definimos el nombre de la tabla
            ToTable("tblClientes");
            //Definimos que campo sera la llave principal o foreing key
            HasKey(c => c.ClienteId);
            //utilizamos una exprecion landa para acceder a los datos de la clase ClsClienteEntity
            Property(c => c.Nombres)
                //Especificamos si el dato a ingresar es nulo o no en este caso es un NOT NULL quiere decir que forzosamente se tiene que ingresar siempre
                .IsRequired()
                //Definimos el tipo de dato del campo
                .HasColumnType("varchar")
                //Definimos la longitud del campo
                .HasMaxLength(16);
            Property(c => c.Apellidos)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(10);
            Property(c => c.Direccion)
                .HasColumnType("varchar")
                .HasMaxLength(10);
            Property(c => c.Telefono)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(10);
        }
    }
}
