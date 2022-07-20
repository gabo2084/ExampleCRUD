using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleCRUD.Entities.Authentication;
using Microsoft.EntityFrameworkCore;

namespace ExampleCRUD.Helpers
{
    public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sql server database
        options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
    }

    public DbSet<User> Users { get; set; }
}
}