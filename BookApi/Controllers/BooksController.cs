using BookApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private static List<Book> _books = new List<Book>()
    {
        new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925 },
        new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960 },
    };

    [HttpGet]
    public IActionResult GetBooks()
    {
        return Ok(_books);
    }

    [HttpPost]
    public IActionResult AddBook([FromBody] Book book)
    {
        _books.Add(book);
        return Ok(book);
    }

}