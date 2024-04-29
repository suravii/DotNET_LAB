using DemoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoAPI.Repositories
{
    public class CollegeRepo : IRepository<College>
    {
        CollegeDbContext _context= null;
        public CollegeRepo(CollegeDbContext context)
        {
            _context= context;            
        }
        public void AddRecord(College model)
        {
            _context.Add(model);
            _context.SaveChanges();
        }

        public College DeleteRecord(College model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<College> GetAllRecords()
        {
            throw new NotImplementedException();
        }

        public College GetSingleRecord(int id)
        {
            throw new NotImplementedException();
        }

        public College UpdateRecord(College model)
        {
            throw new NotImplementedException();
        }
    }
}
