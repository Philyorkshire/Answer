using System.Collections.Generic;
using System.Linq;
using Answer.Domain.Base;

namespace Answer.Domain
{
    public class Person : Entity
    {
        public Person()
        {
            FavouriteColours = new List<Colour>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool IsValid { get; set; }
        public bool IsAuthorised { get; set; }

        public virtual ICollection<Colour> FavouriteColours { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public bool IsPalindrome()
        {
            var reversed = new string(FullName.Replace(" ", "").Reverse().ToArray()).ToLower();
            return FullName.Replace(" ", "").ToLower() == reversed;
        }
    }
}