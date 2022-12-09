using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace NikhilBook.DataAccess.Repository
{
    public interface ISP_Call : IDisposable
    {
        T Single<T>(String procedureName, DynamicParameters param = null);

        //execute something to the database but not retrieve anything
        void Execute(string procedurename, DynamicParameters param = null);
        //retrieves the complete row or record
        T OneRecord<T>(string procedureName, DynamicParameters param = null);

        //get all of the rows
        IEnumerable<T> List<T>(string procedureName, DynamicParameters param = null);

        //stored proceedure that return two table
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null);
    }
}
