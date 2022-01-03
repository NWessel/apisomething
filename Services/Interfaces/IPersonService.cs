using SomeApi.Models;
using System.Collections.Generic;

namespace SomeApi.Services.Interfaces
{
    public interface IPersonService
    {
        public Person Get(int id);
        public IEnumerable<Person> GetAll();
        public void Add(Person person);
        public void Update(Person person);
        public void Delete(int id);
    }
}
