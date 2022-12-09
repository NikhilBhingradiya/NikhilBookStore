using NikhilBook.DataAccess.Repository.IRepository;
using NikhilBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NikhilBook.DataAccess.Repository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void update(Category catogory);
    }
}
