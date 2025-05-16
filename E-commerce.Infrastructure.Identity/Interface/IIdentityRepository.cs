using Microsoft.AspNetCore.Identity;

namespace E_commerce.Infrastructure.Identity.Interface;

public interface IIdentityRepository
{
    void Register(IdentityUser user);
    void LogIn(IdentityUser user);
    void LogOut();

}