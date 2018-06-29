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
        Task<List<Bet>> All([Path] Guid id);
    }

    public class Bet
    {
        public List<string> Bets { get; set; }
    }

    public class BetsClient
    {
        IUsers usersApi;

        public BetsClient()
        {
            usersApi = RestClient.For<IUsers>("http://localhost:5000");
        }

        public Task<List<User>> ListUsers()
        {
            return usersApi.All();
        }
    }
}
