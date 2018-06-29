using RestEase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BettingService
{
    public interface IUsers
    {
        [Get("/users")]
        Task<List<User>> All();
    }

    public class User
    {
        public string Name { get; set; }
    }

    public class UsersClient
    {
        IUsers usersApi;

        public UsersClient()
        {
            usersApi = RestClient.For<IUsers>("http://localhost:5000");
        }

        public Task<List<User>> ListUsers()
        {
            return usersApi.All();
        }
    }
}
