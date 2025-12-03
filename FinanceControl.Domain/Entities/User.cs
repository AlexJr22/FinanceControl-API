namespace FinanceControl.Domain.Entities;

public class User
{
    public Guid UserId { get; private set; }
    public string? Name { get; private set; }
    public string? Surname { get; private set; }
    public string? Email { get; private set; }
    public string? Password { get; private set; }

    public ICollection<Transaction>? Transactions { get; set; }

    public User(Guid userId, string name, string surname,string email, string passward)
    {
        UserId = userId;
        Name = name;
        Surname = surname;
        Email = email;
        Password = passward;
    }

    public User(string name, string surname,string email, string passward)
    {
        Name = name;
        Surname = surname;
        Email = email;
        Password = passward;
    }

    private User() { }
}
