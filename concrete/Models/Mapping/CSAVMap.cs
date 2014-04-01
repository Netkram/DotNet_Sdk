using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace concrete.Models.Mapping
{
    public class CSAVMap : EntityTypeConfiguration<CSAV>
    {
        public CSAVMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CSAV");
            this.Property(t => t.WKENDING).HasColumnName("WKENDING");
            this.Property(t => t.LAST4V).HasColumnName("LAST4V");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
