using CasgemUoW.Business.Abstract;
using CasgemUoW.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CasgemUoW.UI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICustomerProcessService _customerProcessService;
        private readonly ICustomerService _customerService;

        public DefaultController(ICustomerProcessService customerProcessService, ICustomerService customerService)
        {
            _customerProcessService = customerProcessService;
            _customerService = customerService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerProcess customerProcess)
        {
            var valueSender = _customerService.TGetById(customerProcess.SenderID);
            var valueReceiver = _customerService.TGetById(customerProcess.ReceiverID);

            valueReceiver.CustomerBalance += customerProcess.Amount;
            valueSender.CustomerBalance -= customerProcess.Amount;

            List<Customer> modifiedCustomer = new List<Customer>()
            {
                valueSender,valueReceiver
            };
            _customerService.TMultiUpdate(modifiedCustomer);
            _customerProcessService.TInsert(customerProcess);

            return RedirectToAction("CustomerProcessList");
        }
    }
}
