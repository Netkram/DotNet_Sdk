using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace concrete.Models.Mapping
{
    public class PasteErrorMap : EntityTypeConfiguration<PasteError>
    {
        public PasteErrorMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PasteErrors");
            this.Property(t => t.Field0).HasColumnName("Field0");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
