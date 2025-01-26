
using CArch.Application.Commands;
using CArch.Application.Exceptions;
using CArch.Application.Services;
using CArch.Domain.Factories;
using CArch.Domain.Repositories;
using CArch.Shared.Abstractions.Commands;

namespace CArch.Application.Commands.Handlers
{
    public class CreateBookHandler : ICommandHandler<CreateBook>
    {
        private readonly IBookRepository _repository;

        private readonly IBookFactory _factory;

        private readonly IBookReadService _readService;

        public CreateBookHandler(IBookRepository repository, IBookFactory factory, IBookReadService readService)
        {
            _repository = repository;
            _factory = factory;
            _readService = readService;
        }

        public async Task HandleAsync(CreateBook command)
        {
            var (Id, Name, Pages, AuthorId) = command;

            if(await _readService.ExistByNameAsync(Name))
            {
                throw new BookAlreadyExistsException(Name);
            }

            var book = _factory.Create(Id, Name, Pages, AuthorId);
            await _repository.AddAsync(book);
        }
    }
}