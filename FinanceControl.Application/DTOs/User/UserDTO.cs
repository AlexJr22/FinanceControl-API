namespace FinanceControl.Application.DTOs.User;

public record class UserDTO(Guid Id, string Name, string Email, string Password);
