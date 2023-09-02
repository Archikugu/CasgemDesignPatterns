using CasgemCQRS.CQRSPattern.Commands;
using CasgemCQRS.Dal;

namespace CasgemCQRS.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;
        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                Brand = command.Brand,
                Category = command.Category,
                Name = command.Name,
                Price = command.Price,
                Stock = command.Stock
            });
            _context.SaveChanges();
        }
    }
}
