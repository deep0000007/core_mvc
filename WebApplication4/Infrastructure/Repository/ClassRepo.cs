using WebApplication4.Infrastructure.Interface;
using WebApplication4.Models;

namespace WebApplication4.Infrastructure.Repository
{
    public class ClassRepo : IClass
    {
        private readonly DddContext _db;
public ClassRepo(DddContext db)
        {
            _db = db;
        }

        public Class ClassById(int id)
        {
           var data = _db.Classes.FirstOrDefault(x => x.Id == id);
            return data;
        }

        public void Delete(Class cls)
        {
            _db.Classes.Remove(cls);
            _db.SaveChanges();
        }

        public IEnumerable<Class> GetAll()
        {
            var data= _db.Classes.ToList();
            return data;
        }

        public void Insert(Class cls)
        {
            _db.Classes.Add(cls);
            _db.SaveChanges();
        }

        public void Update(Class cls)
        {
            _db.Classes.Update(cls);
            _db.SaveChanges();
        }
    }
}
