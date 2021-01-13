using LiteChatWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace LiteChatWebsite.Data
{
    public class LiteChatContext : DbContext
    {
        public LiteChatContext(DbContextOptions<LiteChatContext> options) : base(options)
        {
        
        }
        
        public DbSet<User> Users
        {
            get; set;
        }

        public DbSet<Role> Roles
        {
            get; set;
        }
    }
}