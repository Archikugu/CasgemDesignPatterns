using CasgemObserver.DAL;

namespace CasgemObserver.ObserverPattern
{
    public class CreateMagazineAnnouncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();
        public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser user)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = user.Name + " " + user.Surname,
                Magazine = "Spor Dergisi",
                Content = "Spor Dergimizin Ağustos 2023 Sayısı Bayimize Geldi"
            });
            context.SaveChanges();
        }
    }
}
