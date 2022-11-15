using System;
using System.Collections.Generic;
using System.Text;
using Dapper;   // downloaded the nuget package 

namespace HarpreetsBooks.DataAccess.Repository.IRepository
{
    public interface ISP_Call : IDisposable        // added all these statements 
    {
        T Single<T>(string procedurename, DynamicParameters param = null);
        void Execute(string procedurename, DynamicParameters Param = null);
        T OneRecord<T>(string procedurename, DynamicParameters Param = null);

        IEnumerable<T> List<T>(string procedurename, DynamicParameters Param = null);
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters Param = null);
    }
}
