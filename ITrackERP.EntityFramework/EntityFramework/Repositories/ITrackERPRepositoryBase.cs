using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ITrackERP.EntityFramework.Repositories
{
    public abstract class ITrackERPRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ITrackERPDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ITrackERPRepositoryBase(IDbContextProvider<ITrackERPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ITrackERPRepositoryBase<TEntity> : ITrackERPRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ITrackERPRepositoryBase(IDbContextProvider<ITrackERPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
