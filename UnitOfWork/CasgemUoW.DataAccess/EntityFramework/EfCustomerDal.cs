using CasgemUoW.DataAccess.Abstract;
using CasgemUoW.DataAccess.Concrete;
using CasgemUoW.DataAccess.Repositories;
using CasgemUoW.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemUoW.DataAccess.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public EfCustomerDal(Context context) : base(context)
        {
        }
    }
}
