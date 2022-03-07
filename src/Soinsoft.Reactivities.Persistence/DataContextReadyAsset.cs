using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Soinsoft.Reactivities.Domain;

namespace Soinsoft.Reactivities.Persistence
{
    public class DataContextReadyAsset : DbContext
    {
        public DataContextReadyAsset(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Mantenimiento> Mantenimientos { get; set; }
    }
}