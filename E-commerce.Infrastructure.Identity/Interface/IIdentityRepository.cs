using Microsoft.AspNetCore.Identity;

namespace E_commerce.Infrastructure.Identity.Interface;

public interface IIdentityRepository
{
    void Register(string userName, string password,string name,string phone);
    void LogIn(IdentityUser user);
    void LogOut();
    void SaveChange();

}