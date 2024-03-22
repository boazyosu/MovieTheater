using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibrary1
{
    public interface IWebClient<T>
    {
        //synchronized
        T Get();
        bool Post(T model);
        bool Post(T model, string fileName);
        bool Post(T model, List<string> files);
        //Asynchronized
        Task<T> GetAsync();
        Task<bool> PostAsync(T model);
        Task<bool> PostAsync(T model, string fileName);
        Task<bool> PostAsync(T model, List<string> files);
    }
}
