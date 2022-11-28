using System;
using System.Collections.Generic;
using System.Text;
using HarpreetsBooks.DataAccess.Repository.IRepository;     // added these using system 
using HarpreetsBooks.Models;
using HarpreetsBooks.DataAccess.Data;
using System.Linq;

namespace HarpreetsBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository // updated all these statements 
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(CoverType coverType)       // implementing this interface to update 
        {
            //  throw new NotImplementedException();
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = coverType.Name;
                //_db.SaveChanges();
            }
        }
    }
}
