using CasgemObserver.DAL;

namespace CasgemObserver.ObserverPattern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser user);
    }
}
