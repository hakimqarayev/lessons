using System;
using System.Collections.Generic;


namespace Homework1
{
   public class GenericRepository<T> : IGenericRepository<T>
    {
        List<T> list;

        public GenericRepository()
        {
            list = new List<T>();
        }

        public int Count
        {
            get { return list.Count; }
        }

        public void Add(T item)
        {
            if (item != null)
                list.Add(item);
        }

        public void Delete(T item)
        {
            if (item != null)
                list.Remove(item);
        }

        public void Get(T item)
        {
        }

        public void Update(T item)
        {
        }
    }
}
