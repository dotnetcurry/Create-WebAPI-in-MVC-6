using System.Collections.Generic;
using WebAPI_WithMVC6.Models;

namespace WebAPI_WithMVC6.Repository
{
    public interface IPersonRepository<T, in TPk>  where T : class 
    {
        IEnumerable<T> Get();
        T Get(TPk id);
        IEnumerable<T> Add(T obj);
        IEnumerable<T> Update(TPk id, T obj);
        IEnumerable<T> Delete(TPk id);
    }

    public class PersonRepository : IPersonRepository<PersonInfo, int>
    {
        DataAccess objds;
        public PersonRepository()
        {
            objds = new DataAccess(); 
        }
        public IEnumerable<PersonInfo> Add(PersonInfo obj)
        {
          return  objds.Add(obj);
        }

        public IEnumerable<PersonInfo> Delete(int id)
        {
            return objds.Delete(id);
        }

        public IEnumerable<PersonInfo> Get()
        {
            return objds.Get();
        }

        public PersonInfo Get(int id)
        {
            return objds.Get(id);
        }

        public IEnumerable<PersonInfo> Update(int id, PersonInfo obj)
        {
            return objds.Update(id, obj);
        }
    }
}
