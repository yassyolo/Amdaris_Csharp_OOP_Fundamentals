using System.Linq.Expressions;

namespace Assessment6.RepositoryPattern.Contract
{
    internal interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        T Find(Expression<Func<T, bool>> predicate);
        IEnumerable<T> FindAll(Expression<Func<T, bool>> predicate);
        T GetById(object id);
    }
}
