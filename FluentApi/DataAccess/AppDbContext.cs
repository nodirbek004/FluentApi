using FluentApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace FluentApi.DataAccess;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        :base(options){}

    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Address> Addresses { get; set; }

}
