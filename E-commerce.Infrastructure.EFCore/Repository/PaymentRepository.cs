using _0_Framework.Infrastructure;
using E_commerce.Domain.PaymentAgg;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Infrastructure.EFCore.Repository;

public class PaymentRepository:RepositoryBase<Guid,Payment>,IPaymentRepository
{
    private readonly ECommerceContext _context;
    public PaymentRepository(ECommerceContext context) : base(context)
    {
        _context = context;
    }


}