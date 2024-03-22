using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterServer.DAL
{
    public interface IModelCreator<T,TSource>
    {
        T CreateModel(TSource source);
    }
}
