using Assessment6.RepositoryPattern.Contract;
using System.Linq.Expressions;
using System.Reflection;

namespace Assessment6.RepositoryPattern.Implementations
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly IList<T> _entities;

        public GenericRepository()
        {
            _entities = new List<T>();
        }

        public void Add(T entity) =>   _entities.Add(entity);

        public void Delete(T entity) =>  _entities.Remove(entity);

        public T Find(Expression<Func<T, bool>> predicate) => _entities.AsQueryable().FirstOrDefault(predicate);
        
        public IEnumerable<T> GetAll() =>  _entities;

        //TODO: Fix this method
        public T GetById(object Id)
        {
            return _entities.SingleOrDefault(x => x.GetType().GetProperty("Id").GetValue(x).ToString() == Id.ToString());
        }

        public void Update(T entity)
        {
            var id = entity.GetType().GetProperty("Id").GetValue(entity);
            var existingEntity = GetById(id);

            var index = _entities.IndexOf(existingEntity);
            _entities[index] = entity;
        }

        public IEnumerable<T> FindAll(Expression<Func<T, bool>> predicate) => _entities.AsQueryable().Where(predicate);
    }
}
