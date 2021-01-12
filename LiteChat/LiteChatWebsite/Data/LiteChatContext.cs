using LiteChatWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace LiteChatWebsite.Data
{
    public class LiteChatContext : DbContext
    {
        public LiteChatContext(DbContextOptions<LiteChatContext> options) : base(options)
        {
        
        }
        
        public DbSet<UserModel> Users
        {
            get; set;
        }

        public DbSet<RoleModel> Roles
        {
            get; set;
        }
    }
}