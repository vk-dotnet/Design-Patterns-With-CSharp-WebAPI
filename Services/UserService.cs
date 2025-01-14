using DesignPatternsWebApi.DesignPatterns.Repository;

namespace DesignPatternsWebApi.Services;

public class UserService
{
    private readonly IRepository<string> _repository;

    public UserService(IRepository<string> repository)
    {
        _repository = repository;
    }

    public void AddUser(string user)
    {
        _repository.Add(user);
    }

    public IEnumerable<string> GetUsers()
    {
        return _repository.GetAll();
    }
}