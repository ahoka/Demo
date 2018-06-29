using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserService.Controllers
{
    [Route("/users")]
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new[] {
                new { Name = "John Doe" },
                new { Name = "Jack Smith" }
            });
        }
    }
}
