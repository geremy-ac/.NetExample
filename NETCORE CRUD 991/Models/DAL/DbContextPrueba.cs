using Microsoft.EntityFrameworkCore;
using NETCORE_CRUD_991.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCORE_CRUD_991.Models.DAL
{
    public class DbContextPrueba:DbContext
    {
        public DbContextPrueba(DbContextOptions<DbContextPrueba> options):
            base(options)
        {

        }

        public DbSet<ValorLibra> valorlibra { get; set; }
        public DbSet<Paquete> paquetes { get; set; }
        public DbSet<TipoMercancia> tipomercancias { get; set; }
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Transportadoras> transportadoras { get; set; }
        public DbSet<Estado> estadoss { get; set; }
    }
}
