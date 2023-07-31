using Microsoft.EntityFrameworkCore;

namespace Minimal_API.Models;
public class ApiContext : DbContext
{

    protected readonly IConfiguration Configuration;

    //public ApiContext(DbContextOptions<ApiContext> options, IConfiguration configuration) : base(options)
    //{
    //    Configuration = configuration;
    //}


    public ApiContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnalyticsSearchCriteriaView>().ToView(nameof(AnalyticsSearchCriteriaView)).HasNoKey();
    }


    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), options => options.CommandTimeout(60));
    }
    public DbSet<AnalyticsSearchCriteriaView> AnalyticsSearchCriteriaView { get; set; }
}