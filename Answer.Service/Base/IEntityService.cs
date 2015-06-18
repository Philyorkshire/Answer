using System.Collections.Generic;
using Answer.Domain.Base;

namespace Answer.Service.Base
{
    public interface IEntityService<T> where T : Entity, new ()
    {
        T GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

        IEnumerable<T> GetAll(); 
    }
}
