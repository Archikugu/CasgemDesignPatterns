using MediatR;

namespace CasgemMediator.MedaiatorPattern.Commands
{
    public class RemoveProductCommand : IRequest
    {
        public RemoveProductCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

    }
}
