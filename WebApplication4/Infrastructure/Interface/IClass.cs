using WebApplication4.Models;

namespace WebApplication4.Infrastructure.Interface
{
    public interface IClass
    {
        IEnumerable<Class> GetAll();
        Class ClassById(int id);
        void Insert(Class cls);
        void Update(Class cls);
        void Delete(Class cls);
    }
}

