using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PrinterTestMVC.Models.Interface;
namespace PrinterTestMVC.Models.Repository
{
    public class ApplyItemsRepository<T> : IRepository<T> where T : class
    {
        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}