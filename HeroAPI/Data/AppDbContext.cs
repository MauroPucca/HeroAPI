using HeroAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HeroAPI.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Hero> Heroes { get; set; }
}