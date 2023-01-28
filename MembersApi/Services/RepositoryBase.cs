using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MembersApi.Contracts;
using MembersApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MembersApi.Services
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected MembersContext _membersContext { get; set; }
        public RepositoryBase(MembersContext membersContext)
        {
            _membersContext = membersContext;
        }
        public IQueryable<T> FindAll() => _membersContext.Set<T>().AsNoTracking();
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) =>
            _membersContext.Set<T>().Where(expression).AsNoTracking();
        public void Create(T entity) => _membersContext.Set<T>().Add(entity);
        public void Update(T entity) => _membersContext.Set<T>().Update(entity);
        public void Delete(T entity) => _membersContext.Set<T>().Remove(entity);
    }
}
