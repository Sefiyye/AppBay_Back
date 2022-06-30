using AppBay.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBay.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Icon> Icons { get; set; }
    }
}
