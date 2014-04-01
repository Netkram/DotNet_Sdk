using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using concrete.Models.Mapping;

namespace concrete.Models
{
    public partial class CYLSContext : DbContext
    {
        static CYLSContext()
        {
            Database.SetInitializer<CYLSContext>(null);
        }

        public CYLSContext()
            : base("Name=CYLSContext")
        {
        }

        public DbSet<Asterisk> Asterisks { get; set; }
        public DbSet<carddata> carddatas { get; set; }
        public DbSet<CSAV> CSAVs { get; set; }
        public DbSet<CYL_LOAD_DIA> CYL_LOAD_DIA { get; set; }
        public DbSet<cyl> cyls { get; set; }
        public DbSet<DISTRIBUTION> DISTRIBUTIONS { get; set; }
        public DbSet<moulddata> moulddatas { get; set; }
        public DbSet<PasteError> PasteErrors { get; set; }
        public DbSet<rem> rems { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<temp> temps { get; set; }
        public DbSet<TEMPTABLE> TEMPTABLEs { get; set; }
        public DbSet<TestSummary> TestSummaries { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<webpages_Membership> webpages_Membership { get; set; }
        public DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        public DbSet<webpages_Roles> webpages_Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AsteriskMap());
            modelBuilder.Configurations.Add(new carddataMap());
            modelBuilder.Configurations.Add(new CSAVMap());
            modelBuilder.Configurations.Add(new CYL_LOAD_DIAMap());
            modelBuilder.Configurations.Add(new cylMap());
            modelBuilder.Configurations.Add(new DISTRIBUTIONMap());
            modelBuilder.Configurations.Add(new moulddataMap());
            modelBuilder.Configurations.Add(new PasteErrorMap());
            modelBuilder.Configurations.Add(new remMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new tempMap());
            modelBuilder.Configurations.Add(new TEMPTABLEMap());
            modelBuilder.Configurations.Add(new TestSummaryMap());
            modelBuilder.Configurations.Add(new UserProfileMap());
            modelBuilder.Configurations.Add(new webpages_MembershipMap());
            modelBuilder.Configurations.Add(new webpages_OAuthMembershipMap());
            modelBuilder.Configurations.Add(new webpages_RolesMap());
        }
    }
}
