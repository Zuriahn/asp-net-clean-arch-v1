
using CArch.Application.Commands;
using CArch.Application.Commands.Handlers;
using CArch.Application.Exceptions;
using CArch.Application.Services;
using CArch.Domain.Factories;
using CArch.Domain.Repositories;
using CArch.Shared.Abstractions.Commands;
using NSubstitute;
using Shouldly;
using Xunit;

namespace CArch.UnitTests.Application
{
    public class CreateAuthorHandlerTests
    {
        private readonly ICommandHandler<CreateAuthor> _commandHandler;
        private readonly IAuthorRepository _repository;
        private readonly IAuthorReadService _readService;
        private readonly IAuthorFactory _factory;

        public CreateAuthorHandlerTests()
        {
            _repository = Substitute.For<IAuthorRepository>();
            _factory = Substitute.For<IAuthorFactory>();
            _readService = Substitute.For<IAuthorReadService>();

            _commandHandler = new CreateAuthorHandler(_repository, _factory, _readService);
        }

        Task Act(CreateAuthor command) => _commandHandler.HandleAsync(command);

        [Fact]
        public async Task HandleAsync_Throws_AuthorAlreadyExistsException_When_Its_Creating()
        {
            var command = new CreateAuthor(Guid.NewGuid(), "Fernando");

            _readService.AuthorExistsAsync(command.Name).Returns(true);

            var exception = await Record.ExceptionAsync(() => Act(command));

            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<AuthorAlreadyExistsException>();
        }
    }
}