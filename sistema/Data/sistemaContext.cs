using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace sistema.Models
{
    public class sistemaContext : DbContext
    {
        public sistemaContext (DbContextOptions<sistemaContext> options)
            : base(options)
        {
        }

        public DbSet<sistema.Models.Pedido> Pedido { get; set; }
    }
}
