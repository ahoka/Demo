using RestEase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BettingService
{
    public interface IBetsApi
    {
        [Get("/bets/{id}")]
        Task<Bet> BetsByUser([Path] Guid id);
    }

    public class Bet
    {
        public List<string> Bets { get; set; }
    }

    public class BetsClient
    {
        IBetsApi bets;

        public BetsClient()
        {
            bets = RestClient.For<IBetsApi>("http://localhost:5002");
        }

        public Task<Bet> Bets(Guid id)
        {
            return bets.BetsByUser(id);
        }
    }
}
