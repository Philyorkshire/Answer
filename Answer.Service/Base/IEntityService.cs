using System.Collections.Generic;
using Answer.Domain.Base;

namespace Answer.Service.Base
{
    public interface IEntityService<TEntity> where TEntity : Entity, new ()
    {
        TEntity GetOrCreate(int? id);
        ICollection<TEntity> GetAll();
        TEntity AddOrUpdate(int? id, TEntity entity);
        void Delete(int id);
    }
}
