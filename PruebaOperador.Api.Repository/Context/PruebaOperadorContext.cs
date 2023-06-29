using Microsoft.EntityFrameworkCore;
using PruebaOperador.Api.Repository.Entity;
using PruebaOperador.Api.Repository.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaOperador.Api.Repository.Context
{
    public class PruebaOperadorContext: DbContext
    {
        public DbSet<Persona> Persona { get; set; }

        public PruebaOperadorContext(DbContextOptions options) : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PersonaEntityConfiguration());
        }
    }
}
