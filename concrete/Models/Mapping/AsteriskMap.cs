using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace concrete.Models.Mapping
{
    public class AsteriskMap : EntityTypeConfiguration<Asterisk>
    {
        public AsteriskMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.labnumber)
                .HasMaxLength(50);

            this.Property(t => t.C7Days)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.C28Days)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Days)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Asterisk");
            this.Property(t => t.labnumber).HasColumnName("labnumber");
            this.Property(t => t.C7Days).HasColumnName("7Days");
            this.Property(t => t.C28Days).HasColumnName("28Days");
            this.Property(t => t.Days).HasColumnName("Days");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
