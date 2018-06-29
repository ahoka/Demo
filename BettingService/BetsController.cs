using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingService
{
    [Route("/bets")]
    public class BetsController : Controller
    {
        UsersClient usersClient;

        public BetsController(UsersClient usersClient)
        {
            this.usersClient = usersClient;
        }

        [HttpGet]
        public async Task<IActionResult> ListBets()
        {
            var users = await usersClient.ListUsers();

            return Ok(users.Select(u => new { User = u.Name, Bet = "None" }));
        }
    }
}
