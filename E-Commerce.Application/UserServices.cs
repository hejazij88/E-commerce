using E_Commerce.Application.Contact.User;
using E_commerce.Infrastructure.Identity.Interface;
using Microsoft.AspNetCore.Identity;

namespace E_Commerce.Application;

public class UserServices:IUserServices
{
    private readonly IIdentityRepository _repository;

    public UserServices(IIdentityRepository repository)
    {
        _repository = repository;
    }

    public void CreateAccount(CreateUser createUser)
    {
        _repository.Register( createUser.Email, createUser.Password , createUser.FirsName+createUser.LastName,createUser.Phone);
        _repository.SaveChange();
    }

    public void EditAccount(EditUser editUser)
    {
        _repository.LogIn(new IdentityUser(){Email = editUser.Email,PasswordHash = editUser.Password});
    }

    public void LogOut()
    {
        _repository.LogOut();
    }
}