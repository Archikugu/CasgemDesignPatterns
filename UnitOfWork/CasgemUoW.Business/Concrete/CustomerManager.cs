using CasgemUoW.Business.Abstract;
using CasgemUoW.DataAccess.Abstract;
using CasgemUoW.DataAccess.UnitOfWork.Abstract;
using CasgemUoW.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemUoW.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        IUowDal _uowDal;
        public CustomerManager(ICustomerDal customerDal, IUowDal uowDal = null)
        {
            _customerDal = customerDal;
            _uowDal = uowDal;
        }
        public void TInsert(Customer t)
        {
            _customerDal.Insert(t);
            _uowDal.Save();
        }
        public void TUpdate(Customer t)
        {
            _customerDal.Update(t);
            _uowDal.Save();
        }
        public void TDelete(Customer t)
        {
            _customerDal.Delete(t);
            _uowDal.Save();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public List<Customer> TGetList()
        {
            return _customerDal.GetList();
        }
        public void TMultiUpdate(List<Customer> t)
        {
            _customerDal.MultiUpdate(t);
            _uowDal.Save();
        }
    }
}
