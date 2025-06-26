namespace Catalog.Domain
{
    public interface IRepository
    {
        IUnitOfWork UnitOfWork { get; }
    }
}