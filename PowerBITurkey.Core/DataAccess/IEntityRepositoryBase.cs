using System.Linq.Expressions;
using PowerBITurkey.Core.Entites;

namespace PowerBITurkey.Core.DataAccess.EntityFramework
{
    public interface IEntityRepositoryBase<TEntity> where TEntity : class, IEntity
    {
        List<TEntity> GetAll(Expression<Func<TEntity,bool>> filterExpression=null);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetByPattern(Expression<Func<TEntity, bool>> filterExpression);
    }
}