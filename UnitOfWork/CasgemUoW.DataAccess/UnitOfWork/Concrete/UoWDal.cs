using CasgemUoW.DataAccess.Concrete;
using CasgemUoW.DataAccess.UnitOfWork.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemUoW.DataAccess.UnitOfWork.Concrete
{
    public class UoWDal : IUowDal
    {
        private readonly Context _context;

        public UoWDal(Context context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
