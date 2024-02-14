using Microsoft.EntityFrameworkCore;
using ProjectApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAPI.Persistence.Context
{
    public class ProjectAPIDbContext : DbContext
    {
        public ProjectAPIDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Poetry>  Poetries { get; set; }
        public DbSet<ContentType> ContentTypes { get; set; }
        public DbSet<ContentAccessType> ContentAccessTypes { get; set; }
        public DbSet<ContentPermissionType> ContentPermissionTypes { get; set; }
        public DbSet<ContentUserPermissions> ContentUserPermissions { get; set; }
    }
}
