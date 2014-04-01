using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace concrete.Models.Mapping
{
    public class DISTRIBUTIONMap : EntityTypeConfiguration<DISTRIBUTION>
    {
        public DISTRIBUTIONMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.LABNO)
                .HasMaxLength(50);

            this.Property(t => t.DISTRIBUTIONS)
                .HasMaxLength(2500);

            // Table & Column Mappings
            this.ToTable("DISTRIBUTIONS");
            this.Property(t => t.LABNO).HasColumnName("LABNO");
            this.Property(t => t.DISTRIBUTIONS).HasColumnName("DISTRIBUTIONS");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
