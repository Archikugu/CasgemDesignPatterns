using CasgemMediator.MedaiatorPattern.Results;
using MediatR;

namespace CasgemMediator.MedaiatorPattern.Queries
{
    public class GetProductUpdateByIDQuery : IRequest<GetProductUpdateByIDQueryResult>
    {
        public GetProductUpdateByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
