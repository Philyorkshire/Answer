using System.Collections.Generic;
using Answer.Domain.Base;

namespace Answer.Domain
{
    public class Colour : Entity
    {
        public Colour()
        {
            People = new List<Person>();
        }

        public string Name { get; set; }

        public virtual ICollection<Person> People { get; set; }  
    }
}