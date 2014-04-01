using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace concrete.Models.Mapping
{
    public class tempMap : EntityTypeConfiguration<temp>
    {
        public tempMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.labnum)
                .HasMaxLength(10);

            this.Property(t => t.testdes)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("temp");
            this.Property(t => t.labnum).HasColumnName("labnum");
            this.Property(t => t.testdes).HasColumnName("testdes");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
