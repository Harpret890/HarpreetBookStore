using System;
using System.Collections.Generic;
using System.Text;
using HarpreetsBooks.Models; // added this using statement 

namespace HarpreetsBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category> //and updated the content 
    {
        void Update(Category category);
    }
}
