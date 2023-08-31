using CasgemUoW.DataAccess.Abstract;
using CasgemUoW.DataAccess.Concrete;
using CasgemUoW.DataAccess.Repositories;
using CasgemUoW.Entities.Concrete;

namespace CasgemUoW.DataAccess.EntityFramework
{
    public class EfCustomerProcessDal : GenericRepository<CustomerProcess>, ICustomerProcessDal
    {
        public EfCustomerProcessDal(Context context) : base(context)
        {
        }
    }
}
