using CasgemCQRS.CQRSPattern.Queries;
using CasgemCQRS.CQRSPattern.Results;
using CasgemCQRS.Dal;

namespace CasgemCQRS.CQRSPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler
    {
        private readonly Context _context;
        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductUpdateByIDQueryResult Handle(GetProductUpdateByIDQuery query)
        {
            var value = _context.Products.Find(query.Id);
            return new GetProductUpdateByIDQueryResult
            {
                Brand = value.Brand,
                Category = value.Category,
                Name = value.Name,
                Price = value.Price,
                ProductID = value.ProductID,
                Stock = value.Stock
            };
        }
    }
}
