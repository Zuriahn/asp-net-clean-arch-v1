using System.Threading.Tasks;

namespace CArch.Shared.Abstractions.Queries
{
    public interface IQueryHandler<in TQuery, TResult> where TQuery : IQuery<TResult>
    {
        Task<TResult> HandleAsync(TQuery query);
    }
}