using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MessagesDAL
{
   public class EF_IGRSCC_DataContext :DbContext
    {
        protected readonly IConfiguration Configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Server=172.16.80.21;Database=IGRSCC;Port=5432;User Id=postgres;Password=admin1234");
        }

        //public EF_IGRSCC_DataContext(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    // connect to postgres with connection string from app settings
        //    options.UseNpgsql(Configuration.GetConnectionString("IGRSCCDB"));
        //}
      //  public EF_IGRSCC_DataContext(DbContextOptions<EF_IGRSCC_DataContext> options) : base(options) { }

        public DbSet<Casehearing> casehearing { get; set; }
        public DbSet<LegalPanelMaster> legalpanel_master { get; set; }
        public DbSet<LegalOpinion> legalopinion { get; set; }
        public DbSet<CourtCase> courtcase { get; set; }



    }
}
