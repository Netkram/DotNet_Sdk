using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace concrete.Models.Mapping
{
    public class TEMPTABLEMap : EntityTypeConfiguration<TEMPTABLE>
    {
        public TEMPTABLEMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.LABNUMBER)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.STRENGTH)
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("TEMPTABLE");
            this.Property(t => t.LABNUMBER).HasColumnName("LABNUMBER");
            this.Property(t => t.STRENGTH).HasColumnName("STRENGTH");
            this.Property(t => t.TESTDATE).HasColumnName("TESTDATE");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
