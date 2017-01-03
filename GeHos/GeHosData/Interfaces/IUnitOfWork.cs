namespace GeHosData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Utiles.RespuestaGenerica;
    using GeHosContract.Contrato;

    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : Entidad;
        IRepository<T> GetRepositoryAudit<T>() where T : Entidad;
        System.Data.Entity.Core.Objects.ObjectContext ObjectContext { get; }
        System.Data.Entity.Core.Objects.ObjectContext ObjectContextAudit { get; }
        RespuestaGenerica SaveChanges(bool execAudit = false, string userName = "", string userPC="");

        //RespuestaGenerica TrackCloseSession(auditoriasesion session);
        //RespuestaGenerica TrackInitSession(string userName, string SysVersion, string usuarioIP, string userPC);

        //Método que almacena registro de Auditoría "Libre" sin EF
        /// <summary>
        /// Guardar registro de Auditoría para Operaciones que no están "ligadas" a estados de EF
        /// por Ej. Autorizar, consultar, etc.
        /// </summary>
        /// <param name="entidad">Entidad en cuestión</param>
        /// <param name="idEntidad">Id de Entidad Involucrada</param>
        /// <param name="accion">Tipo de acción a auditar (Enum AuditAction)</param>
        /// <param name="userName">Usuario que realiza la operación</param>
        //void TrackOperationFree(string entidad, string idEntidad, AuditAction accion, string userName, string userPC);
    }
}
