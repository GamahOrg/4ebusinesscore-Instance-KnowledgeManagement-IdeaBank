using IdeaBank.Infrastructure.LK_GenericRepo;

namespace IdeaBank.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        public Guid _loggedInUserId { get; set; }
        IGRepositoryLookUp<TEntity> RepositoryLookup<TEntity>() where TEntity : BaseEntity<int>;

        #region Transaction
        void BeginTransaction();
        void Commit();
        void Rollback();
        Task BeginTransactionAsync();
        Task CommitAsync();
        Task RollbackAsync();
        #endregion
        #region SaveChanges
        Task SaveChangesAsync();
        void SaveChanges();
        #endregion
    }
}
