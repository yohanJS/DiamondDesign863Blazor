using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PocBlazorApp.Models;

namespace PocBlazorApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<UserPrimaryInfo>? UserPrimaryInfo { get; set; }
    }
}
