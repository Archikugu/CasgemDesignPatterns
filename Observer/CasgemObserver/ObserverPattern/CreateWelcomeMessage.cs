using CasgemObserver.DAL;

namespace CasgemObserver.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();
        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser user)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = user.Name + " " + user.Surname,
                Content = "Dergi bültenimize abone olduğunuz için teşekür ederiz"
            });
            context.SaveChanges();
        }
    }
}
