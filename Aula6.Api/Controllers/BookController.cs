using Microsoft.AspNetCore.Mvc;

namespace Aula6.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpPost]
        public ActionResult<Book> SaveBook(BookDto bookDto)
        {
            //Save data to the database here
            Book book = bookDto;
            return Ok(book);
        }

        [HttpGet()]
        public BookDto GetBook(int id)
        {
            //Retrieved the book from database
            var bookDto = (BookDto)new Book(){Id = 1, Name = "AS Crônicas de Narnia" };
            return bookDto;
        }
        
    }

    public class BookDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Called from GetBook
        public static explicit operator BookDto(Book bookDto)
        {
            return new BookDto() { Id = bookDto.Id, Name = bookDto.Name };
        }

    }

    /// <summary>
    /// <remarks>https://www.c-sharpcorner.com/blogs/operator-overloading-with-implicit-and-explicit-casts-in-c-sharp</remarks>
    /// </summary>
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Called from SaveBook
        public static implicit operator Book(BookDto bookDto)
        {
            return new Book() { Id = bookDto.Id, Name = bookDto.Name };
        }

    }

}
