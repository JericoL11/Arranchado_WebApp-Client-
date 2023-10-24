using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Arranchado_WebApp.GenModels;

namespace Arranchado_WebApp.Data
{
    public class Arranchado_WebAppContext : DbContext
    {
        public Arranchado_WebAppContext (DbContextOptions<Arranchado_WebAppContext> options)
            : base(options)
        {
        }

        public DbSet<Arranchado_WebApp.GenModels.ClassModel> ClassModel { get; set; } = default!;
    }
}
