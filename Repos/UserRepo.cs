/*
    class UserRepo : IUserRepo
{
    private readonly AppDbContext _context;
    public UserRepo(AppDbContext context)
    {
        _context = context;
    }
    public void AddUser(User u)
    {
        _context.Users.Add(u);
    }

    public void DeleteUser(int id)
    {
        var user = _context.Users.Find(id);
        if(user != null)
        {
            _context.Users.Remove(user);
        }
    }

    public List<User> GetAllUsers()
    {
        return _context.Users.ToList();
    }

    public User? GetUser(int id)
    {
        return _context.Users.Find(id);
    }

    public void Save()
    {
        _context.SaveChanges();
    }

    public void UpdateUser(User u)
    {
        _context.Users.Update(u);
    }
}
*/