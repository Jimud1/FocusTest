using FirstCentral.Models.FocusModels;
using System.Web.Mvc;

namespace FirstCentral.Focus.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index(PolicyModel policy)
        {
            return View(policy);
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