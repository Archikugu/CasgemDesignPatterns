using CasgemObserver.DAL;

namespace CasgemObserver.ObserverPattern
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser user)
        {
            context.Discounts.Add(new Discount
            {
                DiscountCode = "DERGIAGUSTOS",
                DiscountAmount = 25,
                DiscountCodeStatus = true
            });
            context.SaveChanges();  
        }
    }
}
