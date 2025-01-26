using System.Threading.Tasks;

namespace CArch.Shared.Abstractions.Commands
{
    public interface ICommandHandler<in TCommand> where TCommand : class, ICommand
    {
        Task HandleAsync(TCommand command);
    }
}