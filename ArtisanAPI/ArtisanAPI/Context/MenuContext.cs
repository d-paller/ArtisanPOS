using ArtisanAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ArtisanAPI.Context
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options) : base(options)
        {
        }

        public DbSet<MenuItem> MenuItems { get; set; }
    }
}
