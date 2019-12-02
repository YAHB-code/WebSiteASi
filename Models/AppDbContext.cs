using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebSiteAsi.Models;
using WebSiteASi.Models;

namespace MuebleriaPageAdmin.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

         protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Cliente> Clientes { get; set;}
        public DbSet<Contador> Contadores { get; set;}

        public DbSet<Cuenta_Cliente> Cuenta_Clientes { get; set;}

        public DbSet<ReciboCaja> Recibos { get; set;}
        
        
    }
}