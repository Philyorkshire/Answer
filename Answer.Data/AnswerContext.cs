using System.Data.Entity;
using Answer.Domain;

namespace Answer.Data
{
    public class AnswerContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Colour> Colours { get; set; }
    }
}
