using E_Commerce.Application;
using E_commerce.Infrastructure.Identity.Interface;
using E_Commerce.Application.Contact.User;
using Microsoft.AspNetCore.Identity;
using Moq;

namespace UnitTest;

public class UserTest
{
    private readonly Mock<IIdentityRepository> _mock;
    private readonly UserServices _userServices;
    public UserTest()
    {
        _mock = new Mock<IIdentityRepository>();
        _userServices = new UserServices(_mock.Object);
    }

    [Fact]
    public void CreateAccount_Register_And_SaveChange()
    {
        var createUser = new CreateUser
        {
            Email = "test@example.com",
            Password = "123456",
            Phone = "09120000000",
            FirsName = "Ali",
            LastName = "Rezaei"
        };

        _userServices.CreateAccount(createUser);

        _userServices.CreateAccount(createUser);

        // Assert
        _mock.Verify(x => x.Register("test@example.com", "123456", "AliRezaei", "09120000000"), Times.Exactly(2));


        _mock.Verify(x => x.SaveChange(), Times.Once);
    }

    [Fact]
    public void EditAccount_Should_Call_LogIn()
    {
        // Arrange
        var editUser = new EditUser
        {
            Email = "edit@example.com",
            Password = "abc123"
        };

        // Act
        _userServices.EditAccount(editUser);

        // Assert
        _mock.Verify(x => x.LogIn(It.Is<IdentityUser>(u =>
            u.Email == editUser.Email &&
            u.PasswordHash == editUser.Password
        )), Times.Once);
    }

    [Fact]
    public void LogOut_Should_Call_LogOut()
    {
        // Act
        _userServices.LogOut();

        // Assert
        _mock.Verify(x => x.LogOut(), Times.Once);
    }
}