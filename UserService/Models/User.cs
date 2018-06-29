namespace UserService.Repositories
{
    public class User
    {
        public User(string name)
        {
            Name = name;
        }

        string Name { get; }
    }
}