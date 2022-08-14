using Microsoft.EntityFrameworkCore;
using WebCrudMvcMysql.Models;

namespace WebCrudMvcMysql.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        { }

        public DbSet<User> User { get; set; }
    }
}
