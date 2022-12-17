using BooksApi.Models;
using BooksApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BooksService _booksService;
        public readonly ILogger _logger;

        public BooksController(BooksService booksService, ILoggerFactory logger)
        {
            _booksService = booksService;
            _logger = logger.CreateLogger<BooksController>();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var book = await _booksService.GetAsync();
            _logger.LogInformation($"Return {book.Count} book.");
            return Ok(book);
        }

        [HttpGet("{id:length(24)}")]
        public async Task<IActionResult> Get(string id)
        {
            var book = await _booksService.GetAsync(id);

            if (book is null)
            {
                _logger.LogInformation($"Book {id}");
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] Book newBook)
        {
            await _booksService.CreateAsync(newBook);

            return CreatedAtAction(nameof(Get), new { id = newBook.Id }, newBook);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Book updatedBook)
        {
            var book = await _booksService.GetAsync(id);

            if (book is null)
            {
                return NotFound();
            }

            updatedBook.Id = book.Id;

            await _booksService.UpdateAsync(id, updatedBook);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var book = await _booksService.GetAsync(id);

            if (book is null)
            {
                return NotFound();
            }

            await _booksService.RemoveAsync(id);

            return NoContent();
        }
    }
}
