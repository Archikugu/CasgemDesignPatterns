using CasgemMediator.MedaiatorPattern.Results;
using MediatR;

namespace CasgemMediator.MedaiatorPattern.Queries
{
    public class GetProductQuery : IRequest<List<GetProductQueryResult>>
    {
    }
}
