using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Open_Source_Project.Models;

namespace Open_Source_Project.Data
{
    public class ContextData  : IdentityDbContext<ApplicationUser>
    {
        public ContextData(DbContextOptions<ContextData> Options):base(Options) { }


        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<User_Table> User_Tables { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User_Table>().HasKey(UserTable => new { UserTable.TableId, UserTable.ApplicationUserId });
            builder.Entity<ApplicationUser>().HasMany<User_Table>().WithOne(U=>U.User);
            builder.Entity<Table>().HasMany<User_Table>().WithOne(U=>U.Table);
            base.OnModelCreating(builder);
        }
    }
}
