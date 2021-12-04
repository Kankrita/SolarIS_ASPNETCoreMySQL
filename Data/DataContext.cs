using Microsoft.EntityFrameworkCore;
using finalWS_2015233.Models;


namespace finalWS_2015233.Data 
{ 
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        
        public DbSet<Client> client { get;set; }

        public DbSet<SolarisPrj> solaris_project { get;set; }

        public DbSet<ProjectToClient> prj_to_client { get; set; }
    } 
   
}