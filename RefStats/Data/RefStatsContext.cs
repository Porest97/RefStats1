using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RefStats.Models.VeiwModels;
using RefStats.VeiwModels;
using RefStats.Models;

namespace RefStats.Models
{
    public class RefStatsContext : DbContext
    {
        public RefStatsContext (DbContextOptions<RefStatsContext> options)
            : base(options)
        {
        }

        public DbSet<RefStats.Models.Domarlista> Domarlista { get; set; }

        public DbSet<RefStats.Models.VeiwModels.DomarlistaViewModel> DomarlistaViewModel { get; set; }

        public DbSet<RefStats.VeiwModels.RefDetailsViewModel> RefDetailsViewModel { get; set; }

        public DbSet<RefStats.Models.Game> Game { get; set; }

        public DbSet<RefStats.Models.Receipt> Receipt { get; set; }

        public DbSet<RefStats.VeiwModels.ReceiptVewModel> ReceiptVewModel { get; set; }
    }
}
