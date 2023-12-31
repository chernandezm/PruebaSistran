﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PruebaOperador.Api.Services.Repository
{
    public interface IRepositoryGeneric<T>
    {
        Task<T> GetByIdAsync(int id);
        List<T> GetById(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(int id, T entity);
    }
}
