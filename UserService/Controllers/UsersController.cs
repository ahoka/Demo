using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserService.Controllers
{
    [Route("/users")]
    public class UsersController : Controller
    {
        object result = new[] { new { Name = "John Doe", Id = Guid.NewGuid() },
                                new { Name = "Jack Smith", Id = Guid.NewGuid() }
                              };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(result);
        }
    }
}
