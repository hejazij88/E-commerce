namespace E_Commerce.Application.Contact.User;

public interface IUserServices
{
    void CreateAccount(CreateUser createUser);
    void EditAccount(EditUser editUser);
    void LogOut();
}