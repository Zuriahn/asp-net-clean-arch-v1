
namespace CArch.Application.Services
{
    public interface IAuthorReadService
    {
        Task<bool> AuthorExistsAsync(string name);
    }
}