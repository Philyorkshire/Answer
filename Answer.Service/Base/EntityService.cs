using System.Collections.Generic;

using System.Linq;
using Answer.Data;
using Answer.Domain.Base;

namespace Answer.Service.Base
{
    public class EntityService<TEntity> : IEntityService<TEntity> where TEntity : Entity, new()
    {
        private readonly AnswerContext _context;

        public EntityService(AnswerContext context)
        {
            _context = context;
        } 

        public TEntity GetOrCreate(int? id)
        {
            var entity = _context.Set<TEntity>().Find(id);
            return entity;
        }

        public IEnumerable<TEntity> GetAll()
        {
            var entities = _context.Set<TEntity>();
            return entities.ToList();
        }

        public TEntity AddOrUpdate(int? id, TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
