using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace DataModel
{
    public partial class ClsCompraEntity
    {
        public Guid CompraId{ get; set; }
        public string Descripcion{ get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public Guid ClienteId { get; set; }
    }


    public partial class ClsCompraEntity
    {
        public virtual ClsClienteEntity ClientesEntities { get; set; }
    }

    public class ClsCompraEntityMapping : EntityTypeConfiguration<ClsCompraEntity>
    {
        public ClsCompraEntityMapping()
        {
            ToTable("tblCompras");
            HasKey(c => c.CompraId);
            Property(c => c.Descripcion)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(16);
            Property(c => c.Cantidad)
                .IsRequired()
                .HasColumnType("int");
            Property(c => c.Precio)
                .HasColumnType("int");
        }
    }
}


