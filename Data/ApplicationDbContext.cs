using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibreriaProgra.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<LibreriaProgra.Models.Producto> Productos { get; set; }
        public DbSet<LibreriaProgra.Models.Usuario> Usuarios { get; set; }
        public DbSet<LibreriaProgra.Models.OrdenDetail> OrdenDetails { get; set; }
    }
}
