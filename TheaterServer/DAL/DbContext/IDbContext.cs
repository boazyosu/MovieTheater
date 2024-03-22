using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.DAL
{
    public interface IDbContext
    {
        void OpenConnection();
        void CloseConnection();
        void CreateCommand();
        void BeginTransaction();
        IDataReader Read(string sql);
        object ReadValue(string sql);
        int Create(string sql);
        int Update(string sql);
        int Delete(string sql);




    }
}
