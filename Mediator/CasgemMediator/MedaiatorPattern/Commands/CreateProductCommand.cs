using MediatR;

namespace CasgemMediator.MedaiatorPattern.Commands
{
    public class CreateProductCommand : IRequest
    {
        public string Name { get; set; }
        public int Stock { get; set; }

    }
}
