namespace DesignPatternsWebApi.Services
{
    public class CqrsService
    {
        private readonly List<string> _users = new();

        public void AddUser(string user)
        {
            _users.Add(user);
        }

        public IEnumerable<string> GetUsers()
        {
            return _users;
        }
    }
}