using System;
using System.Collections.Generic;
using System.Text;
using HarpreetsBooks.DataAccess.Repository.IRepository;     // added these using system 
using HarpreetsBooks.Models;
using HarpreetsBooks.DataAccess.Data;
using System.Linq;

namespace HarpreetsBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository // updated all these statements 
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Category category)       // implementing this interface to update 
        {
            //  throw new NotImplementedException();
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if(objFromDb != null)
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }
    }
}
