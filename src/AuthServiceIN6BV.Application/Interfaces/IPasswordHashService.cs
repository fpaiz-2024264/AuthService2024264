namespace AuthServiceIN6BV.Application.Interfaces;

public interface IPasswordHashService
{
    string hashPassword(string password);
    bool verifyPassword(String password, string hashedPassword);
    
}