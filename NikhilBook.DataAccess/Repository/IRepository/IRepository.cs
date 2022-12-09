using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NikhilBook.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {

        T Get(int id);// retrieve a catagory from the database by id
        //list of catagories based on requirements


        IEnumerable<T> GetAll(
        Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        string includeProperties = null
        );

        T GetFirstorDefault(
        Expression<Func<T, bool>> filter = null,
        string includeProperties = null  // useful foreign key references
        );

        void Add(T entity); // to add an entity
        void Remove(int id);// to renove an object or category

        void Remove(T entity); // another way to remove an object

        void RemoveRange(IEnumerable<T> entity); //remove a complete range of entities
    }
}
