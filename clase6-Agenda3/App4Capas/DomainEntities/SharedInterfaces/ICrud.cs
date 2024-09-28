using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntities.SharedInterfaces
{
    public interface ICrud<T>
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        List<T> GetAll();


    }
}
