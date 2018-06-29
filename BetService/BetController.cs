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
        [Route("{id}")]
        public IActionResult GetByUser([FromRoute] Guid id)
        {
            return Ok(new { Bets = Array.Empty<string>() });
        }
    }
}
