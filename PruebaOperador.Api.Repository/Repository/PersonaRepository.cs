using Microsoft.EntityFrameworkCore;
using PruebaOperador.Api.Repository.Context;
using PruebaOperador.Api.Repository.Entity;
using PruebaOperador.Api.Services.Repository;

namespace PruebaOperador.Api.Repository.Repository
{
    public class PersonaRepository : IRepositoryGeneric<Persona>
    {
        protected readonly PruebaOperadorContext contextDataBase;

        public PersonaRepository(PruebaOperadorContext contextDataBase)
        {
            this.contextDataBase = contextDataBase;
        }

        public async Task<Persona> AddAsync(Persona entity)
        {
            await contextDataBase.Persona.AddAsync(entity);
            await contextDataBase.SaveChangesAsync();
            return entity;
        }

        public List<Persona> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Persona> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Persona>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Persona> UpdateAsync(int id, Persona entity)
        {
            throw new NotImplementedException();
        }
    }
}
