using System;
using System.Collections.Generic;
using System.Text;
using HarpreetsBooks.DataAccess.Repository.IRepository;     // added these using system 
using HarpreetsBooks.Models;
using HarpreetsBooks.DataAccess.Data;
using System.Linq;

namespace HarpreetsBooks.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository // updated all these statements 
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Product product)       // implementing this interface to update 
        {
            //  throw new NotImplementedException();
            var objFromDb = _db.Products.FirstOrDefault(s => s.Id == product.Id);
            if (objFromDb != null)
            {
               if(product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;
                }
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.ISBN = product.ISBN;
                objFromDb.Author = product.Author;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.CoverTypeId = product.CoverTypeId;
            }
        }
    }
}
