namespace DesignPatternsWebApi.DesignPatterns.Repository;
public class UserRepository : IRepository<string>
{
    private readonly List<string> _users = new();

    public void Add(string user)
    {
        _users.Add(user);
    }

    public IEnumerable<string> GetAll()
    {
        return _users;
    }
}
