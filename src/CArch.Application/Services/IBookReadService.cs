
namespace CArch.Application.Services
{
    public interface IBookReadService
    {
        Task<bool> ExistByNameAsync(string name);
    }
}