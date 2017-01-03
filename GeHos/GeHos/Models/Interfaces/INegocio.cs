namespace GeHos.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Web.Mvc;    

    public interface INegocio<T> where T : Entidad
    {
        T Find(object id);
        IList<T> GetAll();
        IQueryable<T> GetAllIq();
        void Add(T item);
        void Update(T item);
        void Remove(object id);
        void Commit(bool execAudit = true);

    }
}
