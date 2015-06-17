using System.Linq;
using System.Web.Mvc;

using Answer.Service;

namespace Answer.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonService _personService;

        public HomeController(IPersonService personService)
        {
            _personService = personService;
        }

        public ActionResult Index()
        {
            var people = _personService.GetAll().OrderBy(p => p.FirstName);
            return View(people);
        }
    }
}