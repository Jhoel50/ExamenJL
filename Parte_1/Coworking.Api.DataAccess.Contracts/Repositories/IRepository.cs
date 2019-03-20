using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Contracts.Repositories
{
    public interface IRepository<T> where T:class
    {
       // Task<bool> Exist(int id);
        List<T> GetAll();
        Task<T> Get(int id);
        Task DeleteAsync (int id);
        Task<T> Update(int id, T element);
        T Add(T element);
    }
}
