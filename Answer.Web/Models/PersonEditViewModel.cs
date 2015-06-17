using System.Collections.Generic;

namespace Answer.Web.Models
{
    public class PersonEditViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool IsAuthorised { get; set; }
        public bool IsEnabled { get; set; }

        public List<ColourViewModel> ColourItems { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName;  }
        }
    }
}