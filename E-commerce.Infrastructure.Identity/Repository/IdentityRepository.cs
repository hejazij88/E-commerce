using E_commerce.Infrastructure.Identity.Interface;
using Microsoft.AspNetCore.Identity;

namespace E_commerce.Infrastructure.Identity.Repository;

public class IdentityRepository:IIdentityRepository
{
    private readonly IdentityContext _context;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;


    public IdentityRepository(IdentityContext context, UserManager<IdentityUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public void Register(string userName, string password, string name, string phone)
    {
        _userManager.CreateAsync(new IdentityUser(userName),password);
    }

    public void LogIn(IdentityUser user)
    {
        _signInManager.SignInAsync(user, isPersistent: false);
    }
    public void LogOut()
    {
        _signInManager.SignOutAsync();
    }

    public void SaveChange()
    {
        _context.SaveChanges();
    }
}