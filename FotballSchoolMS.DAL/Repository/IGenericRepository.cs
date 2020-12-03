using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FotballSchoolMS.DAL.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GEtById(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity, int id);
        void Delete(int id);

    }
}
