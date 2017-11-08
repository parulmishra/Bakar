using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakar.Models
{
    public class BakarContext: IdentityDbContext<User>
    {
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
            .UseMySql(@"Server=localhost;Port=3306;database=Bakar;uid=parul;pwd=parul;");
    }
}
