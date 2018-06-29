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
        BetsClient betsClient;

        public BetsController(UsersClient usersClient, BetsClient betsClient)
        {
            this.usersClient = usersClient;
            this.betsClient = betsClient;
        }

        [HttpGet]
        public async Task<IActionResult> ListBets()
        {
            var users = await usersClient.ListUsers();

            foreach (var u in users)
            {
                var bets = await betsClient.Bets(u.Id);
            }

            return Ok(users.Select(u => new { User = u.Name, Bet = "NONE" }));
        }
    }
}
