using System.Collections.Generic;

namespace WebAPI_WithMVC6.Models
{
    public class PersonInfo
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
    }

    public class PersonData : List<PersonInfo>
    {
        public PersonData()
        {
            Add(new PersonInfo() { PersonId = 1, PersonName = "MS", Age = 39, Gender = "Male", City = "Pune" });
            Add(new PersonInfo() { PersonId = 2, PersonName = "LS", Age = 37, Gender = "Female", City = "Pune" });
            Add(new PersonInfo() { PersonId = 3, PersonName = "TS", Age = 12, Gender = "Male", City = "Pune" });
            Add(new PersonInfo() { PersonId = 4, PersonName = "VB", Age = 32, Gender = "Female", City = "Pune" });
            Add(new PersonInfo() { PersonId = 5, PersonName = "PB", Age = 33, Gender = "Male", City = "Pune" });
            Add(new PersonInfo() { PersonId = 6, PersonName = "AB", Age = 5, Gender = "Male", City = "Pune" });
        }
    }

    public class DataAccess
    {
        public static PersonData Persons;

        public DataAccess()
        {
            Persons = new PersonData();
        }

        public PersonData Get()
        {
            return Persons;
        }

        public PersonInfo Get(int id)
        {
            return Persons.Find(p => p.PersonId == id);
        }

        public PersonData Add(PersonInfo p)
        {
            Persons.Add(p);
            return Persons;
        }

        public PersonData Update(int id, PersonInfo p)
        {
            var per = Persons.Find(px => px.PersonId == id);
            if (per != null)
            {
                Persons.Remove(per);
                Persons.Add(p);
            }
            return Persons;
        }

        public PersonData Delete(int id)
        {
            var per = Persons.Find(px => px.PersonId == id);
            if (per != null)
            {
                Persons.Remove(per);
            }
            return Persons;
        }
    }
}
