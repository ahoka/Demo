using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UserService.Repositories
{
    public class UserRepository : IEnumerable<User>
    {
        public IEnumerator<User> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        void Add(User user)
        {

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        void Remove(User user)
        {

        }
    }
}
