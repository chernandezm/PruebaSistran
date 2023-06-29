
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PruebaOperador.Api.Repository.Entity;

namespace PruebaOperador.Api.Repository.Util
{
    public class PersonaEntityConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("Persona");
            builder.HasKey(a => a.Id);
            builder.Property(x => x.Id);
        }
    }
}
