using CArch.Shared.Abstractions.Commands;

namespace CArch.Application.Commands
{
    public record CreateAuthor(Guid Id, string Name) : ICommand;
}