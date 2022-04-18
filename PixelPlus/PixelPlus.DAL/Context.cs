using Microsoft.EntityFrameworkCore;
using PixelPlus.ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelPlus.DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>options):base(options)
        {

        }
        public DbSet<Fatura> Fatura { get; set; }
        public DbSet<Abone> Abone { get; set; }
        
    }
}
