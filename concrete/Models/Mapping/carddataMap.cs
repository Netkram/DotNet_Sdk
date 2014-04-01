using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace concrete.Models.Mapping
{
    public class carddataMap : EntityTypeConfiguration<carddata>
    {
        public carddataMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.labnumber)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.contractor)
                .HasMaxLength(70);

            this.Property(t => t.projectnumber)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.concsupplier)
                .HasMaxLength(70);

            this.Property(t => t.timemixercharged)
                .HasMaxLength(10);

            this.Property(t => t.typeofmould)
                .HasMaxLength(50);

            this.Property(t => t.tempofconc)
                .HasMaxLength(50);

            this.Property(t => t.specifiedair)
                .HasMaxLength(25);

            this.Property(t => t.wateraoj)
                .HasMaxLength(25);

            this.Property(t => t.trucknumber)
                .HasMaxLength(50);

            this.Property(t => t.nominalsizeofaggregate)
                .HasMaxLength(25);

            this.Property(t => t.typeofcement)
                .HasMaxLength(30);

            this.Property(t => t.of)
                .HasMaxLength(50);

            this.Property(t => t.timecylscast)
                .HasMaxLength(10);

            this.Property(t => t.slump)
                .HasMaxLength(50);

            this.Property(t => t.airtemp)
                .HasMaxLength(50);

            this.Property(t => t.air)
                .HasMaxLength(10);

            this.Property(t => t.byauth)
                .HasMaxLength(50);

            this.Property(t => t.loadnumber)
                .HasMaxLength(5);

            this.Property(t => t.drumctrevs)
                .HasMaxLength(20);

            this.Property(t => t.airentagent)
                .HasMaxLength(50);

            this.Property(t => t.inicurtempmax)
                .HasMaxLength(50);

            this.Property(t => t.inicurtempmin)
                .HasMaxLength(50);

            this.Property(t => t.productcode)
                .HasMaxLength(30);

            this.Property(t => t.cylscastby)
                .HasMaxLength(50);

            this.Property(t => t.costsheet)
                .HasMaxLength(15);

            this.Property(t => t.project)
                .HasMaxLength(100);

            this.Property(t => t.specifiedslump)
                .HasMaxLength(53);

            this.Property(t => t.prjlocation)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("carddata");
            this.Property(t => t.labnumber).HasColumnName("labnumber");
            this.Property(t => t.setnumber).HasColumnName("setnumber");
            this.Property(t => t.datecast).HasColumnName("datecast");
            this.Property(t => t.spec28dayst).HasColumnName("spec28dayst");
            this.Property(t => t.contractor).HasColumnName("contractor");
            this.Property(t => t.projectnumber).HasColumnName("projectnumber");
            this.Property(t => t.locationonst).HasColumnName("locationonst");
            this.Property(t => t.concsupplier).HasColumnName("concsupplier");
            this.Property(t => t.timemixercharged).HasColumnName("timemixercharged");
            this.Property(t => t.typeofmould).HasColumnName("typeofmould");
            this.Property(t => t.tempofconc).HasColumnName("tempofconc");
            this.Property(t => t.specifiedair).HasColumnName("specifiedair");
            this.Property(t => t.wateraoj).HasColumnName("wateraoj");
            this.Property(t => t.trucknumber).HasColumnName("trucknumber");
            this.Property(t => t.nominalsizeofaggregate).HasColumnName("nominalsizeofaggregate");
            this.Property(t => t.typeofadmixer).HasColumnName("typeofadmixer");
            this.Property(t => t.typeofcement).HasColumnName("typeofcement");
            this.Property(t => t.of).HasColumnName("of");
            this.Property(t => t.timecylscast).HasColumnName("timecylscast");
            this.Property(t => t.slump).HasColumnName("slump");
            this.Property(t => t.airtemp).HasColumnName("airtemp");
            this.Property(t => t.air).HasColumnName("air");
            this.Property(t => t.byauth).HasColumnName("byauth");
            this.Property(t => t.loadnumber).HasColumnName("loadnumber");
            this.Property(t => t.drumctrevs).HasColumnName("drumctrevs");
            this.Property(t => t.airentagent).HasColumnName("airentagent");
            this.Property(t => t.inicurtempmax).HasColumnName("inicurtempmax");
            this.Property(t => t.inicurtempmin).HasColumnName("inicurtempmin");
            this.Property(t => t.productcode).HasColumnName("productcode");
            this.Property(t => t.labremarks).HasColumnName("labremarks");
            this.Property(t => t.cylscastby).HasColumnName("cylscastby");
            this.Property(t => t.costsheet).HasColumnName("costsheet");
            this.Property(t => t.project).HasColumnName("project");
            this.Property(t => t.sizeofmould).HasColumnName("sizeofmould");
            this.Property(t => t.specifiedslump).HasColumnName("specifiedslump");
            this.Property(t => t.prjlocation).HasColumnName("prjlocation");
            this.Property(t => t.ID).HasColumnName("ID");
        }
    }
}
