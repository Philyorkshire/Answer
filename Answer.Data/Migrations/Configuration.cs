using System.Collections.Generic;

using Answer.Domain;

namespace Answer.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Answer.Data.AnswerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        } 

        protected override void Seed(AnswerContext context)
        {
            var people = new List<Person>
            {
                new Person() { Id = 1, FirstName = "Willis", LastName = "Tibbs", IsAuthorised = true, IsValid = true, IsEnabled = false },
                new Person() { Id = 2, FirstName = "Sharon", LastName = "Halt", IsAuthorised = false, IsValid = false, IsEnabled = false },
                new Person() { Id = 3, FirstName = "Patrick", LastName = "Kerr", IsAuthorised = true, IsValid = true, IsEnabled = true },
                new Person() { Id = 4, FirstName = "Lilly", LastName = "Hale", IsAuthorised = false, IsValid = false, IsEnabled = false },
                new Person() { Id = 5, FirstName = "Joel", LastName = "Daly", IsAuthorised = true, IsValid = true, IsEnabled = true },
                new Person() { Id = 6, FirstName = "Imogen", LastName = "Kent", IsAuthorised = false, IsValid = false, IsEnabled = false },
                new Person() { Id = 7, FirstName = "George", LastName = "Edwards", IsAuthorised = true, IsValid = true, IsEnabled = false },
                new Person() { Id = 8, FirstName = "Gabriel", LastName = "Francis", IsAuthorised = false, IsValid = false, IsEnabled = false },
                new Person() { Id = 9, FirstName = "Courtney", LastName = "Arnold", IsAuthorised = true, IsValid = true, IsEnabled = true },
                new Person() { Id = 10, FirstName = "Brian", LastName = "Allen", IsAuthorised = true, IsValid = true, IsEnabled = true },
                new Person() { Id = 11, FirstName = "Bo", LastName = "Bob", IsAuthorised = true, IsValid = true, IsEnabled = false }
            };

            foreach (var person in people)
            {
                context.People.AddOrUpdate(person);
                context.SaveChanges();
            }

            // ADD COLOURS
            var colours = new List<Colour>
            {
                new Colour() {Id = 1, Name = "Red", IsEnabled = true },
                new Colour() {Id = 2, Name = "Green", IsEnabled = true},
                new Colour() {Id = 3, Name = "Blue", IsEnabled = true}
            };

            // Red
            colours[0].People = new List<Person>
            {
                people[0],
                people[1],
                people[3],
                people[5],
                people[8],
                people[9],
                people[10],
            };

            // Green
            colours[1].People = new List<Person>
            {
                people[0],
                people[1],
                people[2],
                people[3],
                people[4],
                people[6],
                people[7],
                people[9],
            };

            // Blue
            colours[2].People = new List<Person>
            {
                people[0],
                people[1],
                people[3],
                people[6],
                people[9],
            };


            foreach (var colour in colours)
            {
                context.Colours.AddOrUpdate(colour);
                context.SaveChanges();
            }
        }
    }
}
