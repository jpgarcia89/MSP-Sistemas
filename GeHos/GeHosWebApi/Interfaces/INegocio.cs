namespace GeHosWebApi
{
    using System.Collections.Generic;
    using System.Linq;
    using GeHosContract.Contrato;

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
