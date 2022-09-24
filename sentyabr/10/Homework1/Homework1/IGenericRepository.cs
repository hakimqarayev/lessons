using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    interface IGenericRepository<T>
    {
        
        void Add(T item);

        void Delete(T item);

        void Update(T item);

        void Get(T item);

    }
}
