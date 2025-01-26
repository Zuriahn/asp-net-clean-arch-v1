
using CArch.Application.Commands;
using CArch.Application.DTO;
using CArch.Application.Queries;
using CArch.Shared.Abstractions.Commands;
using CArch.Shared.Abstractions.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CArch.Api.Controllers
{
    public class BookController : BaseController
    {
        private readonly ICommandDispatcher _commandDispatcher;

        private readonly IQueryDispatcher _queryDispatcher;

        public BookController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDto>>> Get([FromQuery] SearchBooks query)
        {
            var result = await _queryDispatcher.QueryAsync(query);
            return OkOrNotFound(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateBook command)
        {
            await _commandDispatcher.DispatchAsync(command);
            return CreatedAtAction(nameof(Get), new { id = command.Id }, null);
        }
    }
}