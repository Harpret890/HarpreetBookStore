using System;
using System.Collections.Generic;
using HarpreetsBooks.Models;
using System.Text;

namespace HarpreetsBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
