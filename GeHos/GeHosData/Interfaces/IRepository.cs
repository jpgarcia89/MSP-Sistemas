
namespace GeHosData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using GeHosContract.Contrato;

    public interface IRepository<T> where T : Entidad
    {
        T Find(object id);
        IQueryable<T> GetAll();      
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
