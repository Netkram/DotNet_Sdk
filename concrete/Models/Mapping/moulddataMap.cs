using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace concrete.Models.Mapping
{
    public class moulddataMap : EntityTypeConfiguration<moulddata>
    {
        public moulddataMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.mouldtype)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("moulddata");
            this.Property(t => t.moulddia).HasColumnName("moulddia");
            this.Property(t => t.mouldht).HasColumnName("mouldht");
            this.Property(t => t.mouldsize).HasColumnName("mouldsize");
            this.Property(t => t.mouldtype).HasColumnName("mouldtype");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
