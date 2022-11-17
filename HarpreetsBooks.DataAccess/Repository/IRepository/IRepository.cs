using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;


namespace HarpreetsBooks.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id); // Retrive the data from the category from the database by id
        //List of CATEGORIES BASED ON REQUIREMENTS 
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null // usefull for foreign key refernces
            );

        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );
        void Add(T entity); // to add an enitity 
        void Remove(int id); // to reove an object or category 
        void Remove(T entity); // another way to remove an object 
        void RemoveRange(IEnumerable<T> entity); // removes a complete rage of entities 
    }
}
