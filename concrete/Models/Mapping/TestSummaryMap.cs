using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace concrete.Models.Mapping
{
    public class TestSummaryMap : EntityTypeConfiguration<TestSummary>
    {
        public TestSummaryMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.projectnumber)
                .HasMaxLength(10);

            this.Property(t => t.labnumber)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("TestSummary");
            this.Property(t => t.projectnumber).HasColumnName("projectnumber");
            this.Property(t => t.labnumber).HasColumnName("labnumber");
            this.Property(t => t.setnumber).HasColumnName("setnumber");
            this.Property(t => t.datecast).HasColumnName("datecast");
            this.Property(t => t.strength).HasColumnName("strength");
            this.Property(t => t.datetested).HasColumnName("datetested");
            this.Property(t => t.spec28dayst).HasColumnName("spec28dayst");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
