namespace AuthServiceIN6BV.Application.Interfaces;

public interface IPasswordHashService
{
    string HashPassword(string password);
    bool VerifyPassword(String password, string hashedPassword);
    
}