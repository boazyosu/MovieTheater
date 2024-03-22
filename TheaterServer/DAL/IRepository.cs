using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterServer.DAL
{
    public interface IRepository<T>
    {
        //Read
        List<T> ReadAll();
        T Read(object id);
        object ReadValue();

        // Create

        bool Insert(T model);

        // Update
        bool Update(T model);

        //Delete
        bool Delete(string id);
        bool Delete(int id);
        bool Delete(T model);



    }
}
