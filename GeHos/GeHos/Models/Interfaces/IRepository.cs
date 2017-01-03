
namespace GeHos.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;    

    public interface IRepository<T> where T : Entidad
    {
        T Find(object id);
        IQueryable<T> GetAll();      
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
