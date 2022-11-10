using System;
using System.Collections.Generic;
using System.Text;
using HarpreetsBooks.DataAccess.Repository.IRepository;     // added these using system 
using HarpreetsBooks.Models;
using HarpreetsBooks.DataAccess.Data;

namespace HarpreetsBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository // updated all these statements 
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
