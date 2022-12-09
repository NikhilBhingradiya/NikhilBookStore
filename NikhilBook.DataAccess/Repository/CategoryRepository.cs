//using NikhilBook.DataAccess.Data;
using NikhilBook.DataAccess.Repository.IRepository;
using NikhilBook.Models;
using NikhilBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikhilBook.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository

    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

      

        public void update(Category catogory)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == catogory.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = catogory.Name;
            }
        }
    }
}