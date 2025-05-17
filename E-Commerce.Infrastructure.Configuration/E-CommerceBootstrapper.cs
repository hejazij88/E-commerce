using System.ComponentModel.Design;
using E_Commerce.Application;
using E_Commerce.Application.Contact.Cart;
using E_Commerce.Application.Contact.Category;
using E_Commerce.Application.Contact.Order;
using E_Commerce.Application.Contact.Payment;
using E_Commerce.Application.Contact.Product;
using E_Commerce.Application.Contact.User;
using E_commerce.Domain.CartAgg;
using E_commerce.Domain.CategoryAgg;
using E_commerce.Domain.OrderAgg;
using E_commerce.Domain.PaymentAgg;
using E_commerce.Domain.ProductAgg;
using E_commerce.Infrastructure.EFCore;
using E_commerce.Infrastructure.EFCore.Repository;
using E_commerce.Infrastructure.Identity.Interface;
using Microsoft.Extensions.DependencyInjection;
using E_commerce.Infrastructure.Identity.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Infrastructure.Configuration;

public class E_CommerceBootstrapper
{
    public static void Configure(IServiceCollection Service, string connection)
    {
        Service.AddTransient<ICartServices, CartServices>();
        Service.AddTransient<ICartRepository, CartRepository>();
        Service.AddTransient<ICategoryRepository, CategoryRepository>();
        Service.AddTransient<ICategoryServices, CategoryServices>();

        Service.AddTransient<IOrderServices, OrderServices>();
        Service.AddTransient<IOrderRepository, OrderRepository>();


        Service.AddTransient<IPaymentServices, PaymentServices>();
        Service.AddTransient<IPaymentRepository, PaymentRepository>();


        Service.AddTransient<IProductServices, ProductServices>();
        Service.AddTransient<IProductRepository, ProductRepository>();


        Service.AddTransient<IUserServices, UserServices>();
        Service.AddTransient<IIdentityRepository, IdentityRepository>();

        Service.AddDbContext<ECommerceContext>(options =>
            options.UseSqlServer(connection));
    

    Service.AddIdentity<IdentityUser, IdentityRole>()
            .AddEntityFrameworkStores<ECommerceContext>()
            .AddDefaultTokenProviders();

    }
}