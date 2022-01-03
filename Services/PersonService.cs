using SomeApi.Models;
using SomeApi.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SomeApi.Services
{
    public class PersonService : IPersonService
    {
        List<Person> _persons = new List<Person> { new Person() { Id = 1, Age = 31, Name = "Nicklas" }, new Person() { Id = 2, Age = 30, Name = "Essie" } };

        public void Add(Person person)
        {
            _persons.Add(person);
        }

        public void Delete(int id)
        {
            var personTodelete = _persons.FirstOrDefault(p => p.Id == id);
            _persons.Remove(personTodelete);
        }

        public Person Get(int id)
        {
            return _persons.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Person> GetAll()
        {
            return _persons;
        }

        public void Update(Person person)
        {
            var personToUpdate = _persons.FirstOrDefault(p => p.Id == person.Id);
            if (personToUpdate != null)
            {
                personToUpdate.Id = person.Id;
                personToUpdate.Name = person.Name;
                personToUpdate.Age = person.Age;
            }
        }
    }
}
