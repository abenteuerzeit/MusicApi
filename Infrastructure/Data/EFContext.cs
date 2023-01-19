using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Songs;

namespace Infrastructure.Data
{
    public class EFContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
        }
    }
}
