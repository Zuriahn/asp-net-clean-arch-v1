using CArch.Shared.Abstractions.Commands;

namespace CArch.Application.Commands
{
    public record CreateBook(Guid Id, string Name, int Pages, Guid AuthorId) : ICommand;
}