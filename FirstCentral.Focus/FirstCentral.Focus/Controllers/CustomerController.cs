using System.Web.Mvc;

namespace FirstCentral.Focus.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DisplayCustomerSearch()
        {
            return PartialView("_customerSearch");
        }

        public ActionResult DisplayCustomerAdd()
        {
            return PartialView("_customerAdd");
        }
    }
}