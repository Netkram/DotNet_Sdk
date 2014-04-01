using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace concrete.Models.Mapping
{
    public class CYL_LOAD_DIAMap : EntityTypeConfiguration<CYL_LOAD_DIA>
    {
        public CYL_LOAD_DIAMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.LABNUMBER)
                .HasMaxLength(50);

            this.Property(t => t.LOAD_KN)
                .HasMaxLength(50);

            this.Property(t => t.LOAD_P)
                .HasMaxLength(50);

            this.Property(t => t.DIAMETER)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CYL_LOAD_DIA");
            this.Property(t => t.LABNUMBER).HasColumnName("LABNUMBER");
            this.Property(t => t.TESTDATE).HasColumnName("TESTDATE");
            this.Property(t => t.LOAD_KN).HasColumnName("LOAD_KN");
            this.Property(t => t.LOAD_P).HasColumnName("LOAD_P");
            this.Property(t => t.DIAMETER).HasColumnName("DIAMETER");
            this.Property(t => t.STRENGTH).HasColumnName("STRENGTH");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
