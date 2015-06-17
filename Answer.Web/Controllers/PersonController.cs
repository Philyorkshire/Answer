using System.Web.Mvc;
using Answer.Service;
using Answer.Web.Models;

namespace Answer.Web.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        public ActionResult Edit(int id)
        {
            var person = _personService.GetOrCreate(id);
            return View(person);
        }

        public ActionResult Edit(int id, PersonEditViewModel model)
        {
            
        }
    }
}