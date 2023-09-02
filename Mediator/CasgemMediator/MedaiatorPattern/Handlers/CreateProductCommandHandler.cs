using CasgemMediator.DAL;
using CasgemMediator.MedaiatorPattern.Commands;
using MediatR;

namespace CasgemMediator.MedaiatorPattern.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _context.Products.Add(new Product
            {
                Name = request.Name,
                Stock = request.Stock,
                Brand = "Bilinmiyor",
                Price = 0
            });

            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
