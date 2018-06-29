using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace BetService
{
    [Route("/bets")]
    public class BetController : Controller
    {
        [HttpGet]
        public IActionResult GetByUser(Guid id)
        {
            return Ok(new { Bets = Array.Empty<string>() });
        }
    }
}
