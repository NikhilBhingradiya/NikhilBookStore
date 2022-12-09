using NikhilBook.DataAccess.Repository;
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
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            var objFromDb = _db.Product.FirstOrDefault(s => s.Id == product.Id);
            if (objFromDb != null)

            {
                if(product.ImageUrl !=null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;
                }

                objFromDb.Title = product.Title;
               
            }
          
        }
    }
}