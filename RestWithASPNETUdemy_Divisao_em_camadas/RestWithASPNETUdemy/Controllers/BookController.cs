using System;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using RestWithASPNETUdemy.Business.Implementations;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private readonly IBookBusiness _BookBusiness;

        public BookController(ILogger<BookController> logger, IBookBusiness BookBusiness)
        {
            _BookBusiness = BookBusiness;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_BookBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var Book = _BookBusiness.FindByID(id);
            if (Book == null) return NotFound();
            return Ok(Book);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Book Book)
        {
            if (Book == null) return BadRequest();
            return Ok(_BookBusiness.Create(Book));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Book Book)
        {
            if (Book == null) return BadRequest();
            return Ok(_BookBusiness.Update(Book));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _BookBusiness.Delete(id);
            return NoContent();
        }
    }
}