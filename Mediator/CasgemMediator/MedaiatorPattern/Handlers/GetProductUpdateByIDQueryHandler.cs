using CasgemMediator.DAL;
using CasgemMediator.MedaiatorPattern.Queries;
using CasgemMediator.MedaiatorPattern.Results;
using MediatR;

namespace CasgemMediator.MedaiatorPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler : IRequestHandler<GetProductUpdateByIDQuery, GetProductUpdateByIDQueryResult>
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetProductUpdateByIDQueryResult> Handle(GetProductUpdateByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);
            return new GetProductUpdateByIDQueryResult
            {
                Brand = values.Brand,
                Category = values.Category,
                Name = values.Name,
                Price = values.Price,
                ProductID = values.ProductID,
                Stock = values.Stock,
            };
        }
    }
}
