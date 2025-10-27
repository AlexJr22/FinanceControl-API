namespace FinanceControl.Domain.Entities;

public class User(Guid id, string name, string email, string passward)
{
    public Guid Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Email { get; set; } = email;
    public string Password { get; set; } = passward;
}
