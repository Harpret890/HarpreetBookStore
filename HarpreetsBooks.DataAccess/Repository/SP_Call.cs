using System;
using System.Collections.Generic;
using System.Text;
using HarpreetsBooks.DataAccess.Repository.IRepository;
using HarpreetsBooks.DataAccess.Data;
using Dapper;
using Microsoft.EntityFrameworkCore;

namespace HarpreetsBooks.DataAccess.Repository
{
    public class SP_Call : ISP_Call
    {
        private readonly ApplicationDbContext _db;
        private static string ConnectionString = ""; // needed to called the stored procedures

        // constructor to open a SQL connectiom 
        public SP_Call(ApplicationDbContext db)
        {
            _db = db;
            ConnectionString = db.Database.GetDbConnection().ConnectionString;
        }
        //  implements the ISP_Call interface
        public void Dispose()
        {
            _db.Dispose();
        }
        public void Execute(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                sqlCon.Execute(procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        public IEnumerable<T> List<T>(string procedureName sqlCon = new SqlConnection(ConnectionString))
        {
            sqlCon.Open();
            return sqlCon.Query<T>(procedureName, ParamArrayAttribute, commandType: System.Data.CommandType.StoredProcedure);
        }
        public Tuple<IEnumerable<T1>,IEnumerable<T2>> List<T1,T2>(string procedureName, DynamicParameters param = null)
        {

        }
    }
}
