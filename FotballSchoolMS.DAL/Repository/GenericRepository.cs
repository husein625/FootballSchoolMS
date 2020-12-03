using FotballSchoolMS.DAL.Domain;
using FotballSchoolMS.DAL.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FotballSchoolMS.DAL.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        ApplicationDbContext _applicationDbContext;
        private DbSet<TEntity> entities;

        public GenericRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            entities = applicationDbContext.Set<TEntity>();
        }

        public void Delete(int id)
        {
            TEntity entity = entities.SingleOrDefault(s => s.Id == id);
            entities.Remove(entity);
            _applicationDbContext.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return entities.AsEnumerable();
        }

        public TEntity GEtById(int id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }

        public void Insert(TEntity entity)
        {
            entities.Add(entity);
            _applicationDbContext.SaveChanges();
        }

        public void Update(TEntity entity, int id)
        {
            _applicationDbContext.SaveChanges();
        }
    }
}
