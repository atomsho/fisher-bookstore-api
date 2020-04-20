using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Fisher.Bookstore.Services;

namespace Fisher.Bookstore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class BooksController : ControllerBase
    {
    private IBooksRepository booksRepository;
    public BooksController(IBooksRepository repository){
        booksRepository = repository;
    }
    [HttpGet]
    public IActionResult GetAll(){
        return Ok(booksRepository.GetBooks());
    }
    }
}