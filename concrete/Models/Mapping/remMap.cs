using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace concrete.Models.Mapping
{
    public class remMap : EntityTypeConfiguration<rem>
    {
        public remMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.remark)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("rems");
            this.Property(t => t.remark).HasColumnName("remark");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
