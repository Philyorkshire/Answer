using System.Linq;
using System.Web.Mvc;

using Answer.Service;
using Answer.Web.Models;

using AutoMapper;

namespace Answer.Web.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;
        private readonly IColourService _colourService;

        public PersonController(IPersonService personService, IColourService colourService)
        {
            _colourService = colourService;
            _personService = personService;
        }

        public ActionResult Edit(int id)
        {
            var person = _personService.GetById(id);
            var viewModel = Mapper.Map<PersonEditViewModel>(person);

            var colours = _colourService.GetAll();

            foreach (var colour in colours)
            {
                var colourItem = new ColourViewModel()
                {
                    Id = colour.Id,
                    Name = colour.Name,
                };

                if (person.FavouriteColours.Any(c => c.Id == colour.Id))
                {
                    colourItem.IsActive = true;
                }

                 viewModel.ColourItems.Add(colourItem);
            }

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(int id, PersonEditViewModel model)
        {
            var colourId = model.ColourItems.Where(c => c.IsActive).Select(c => c.Id).ToList();
            _personService.UpdatePersonPreferences(id, model.IsAuthorised, model.IsEnabled, colourId);
            return RedirectToAction("Index", "Home");
        }
    }
}