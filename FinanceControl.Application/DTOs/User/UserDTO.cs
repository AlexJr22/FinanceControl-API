namespace FinanceControl.Application.DTOs;

public record class UserDTO(Guid Id, string Name, string Email, string Password);
