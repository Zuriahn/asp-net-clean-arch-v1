
using CArch.Application.Exceptions;
using CArch.Application.Services;
using CArch.Domain.Factories;
using CArch.Domain.Repositories;
using CArch.Shared.Abstractions.Commands;

namespace CArch.Application.Commands.Handlers
{
    public class CreateAuthorHandler : ICommandHandler<CreateAuthor>
    {
        private readonly IAuthorRepository _repository;

        private readonly IAuthorFactory _factory;

        private readonly IAuthorReadService _readService;

        public CreateAuthorHandler(IAuthorRepository repository, IAuthorFactory factory, IAuthorReadService readService)
        {
            _repository = repository;
            _factory = factory;
            _readService = readService;
        }

        public async Task HandleAsync(CreateAuthor command)
        {
            var (Id, Name) = command;

            if (await _readService.AuthorExistsAsync(Name))
            {
                throw new AuthorAlreadyExistsException(Name);
            }

            var author = _factory.Create(Id, Name);
            await _repository.AddAsync(author);
        }
    }
}