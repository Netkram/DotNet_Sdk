using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace concrete.Models.Mapping
{
    public class cylMap : EntityTypeConfiguration<cyl>
    {
        public cylMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.labnumber)
                .HasMaxLength(10);

            this.Property(t => t.setnumber)
                .HasMaxLength(50);

            this.Property(t => t.cylnumber)
                .HasMaxLength(5);

            this.Property(t => t.remarks)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("cyls");
            this.Property(t => t.labnumber).HasColumnName("labnumber");
            this.Property(t => t.setnumber).HasColumnName("setnumber");
            this.Property(t => t.cylnumber).HasColumnName("cylnumber");
            this.Property(t => t.datereclab).HasColumnName("datereclab");
            this.Property(t => t.datetested).HasColumnName("datetested");
            this.Property(t => t.cylwt).HasColumnName("cylwt");
            this.Property(t => t.cyldensity).HasColumnName("cyldensity");
            this.Property(t => t.strength).HasColumnName("strength");
            this.Property(t => t.remarks).HasColumnName("remarks");
            this.Property(t => t.number).HasColumnName("number");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
