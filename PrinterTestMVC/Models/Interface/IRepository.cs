using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrinterTestMVC.Models.Interface
{
    public interface IRepository<T>:IDisposable where T:class
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(int Id);
        IQueryable<T> GetAll();
        void SaveChange();
    }
}