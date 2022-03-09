using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taaghche.Application.Contracts;
using Taaghche.Domain.Models;

namespace Taaghche.EndPoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BookModel>>Get(int id)
        {
            var result = await _bookService.Get(id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
