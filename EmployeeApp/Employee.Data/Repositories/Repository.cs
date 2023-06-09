﻿
using EmployeeApp.Core.Models.Basemodels;

namespace EmployeeApp.Data.Repositories
{
    public class Repository<T> where T : Basemodel
    {
        private readonly List<T> _items=new List<T>();

        public void Create(T model) 
        {
            _items.Add( model);
        }
        public void Delete(T model)
        {
            _items.Remove( model);
        }
        public T Get(int id)
        {
           foreach (T item in _items)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        public List<T> GetAll() 
        {
            return _items;
        }


    }
}
