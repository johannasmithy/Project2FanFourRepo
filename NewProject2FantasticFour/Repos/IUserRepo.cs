interface IUserRepo
{
    public void AddUser(User u);
    public User? GetUser(int id);
    public List<User> GetAllUsers();
    public void UpdateUser(User u);
    public void DeleteUser(int id);
    public void Save();
}