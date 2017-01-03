namespace GeHos.Models
{
    using System;
    using System.Web;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using System.Net;
    using System.Net.Sockets;
    using Utiles.RespuestaGenerica;

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public const string NoHayMasDatos = "-1";
        #region Properties

        private bool _disposed;
        private bool _audit;
        private readonly DbContext _dbContext;
        private readonly DbContext _dbContextAudit;
        //private readonly IRepository<auditoriasesion> _auditoriaSesionRepositorio;
        //private readonly IRepository<auditoriaoperacion> _auditoriaOperacionRepositorio;

        public ObjectContext ObjectContext
        {
            get
            {
                return (_dbContext as IObjectContextAdapter).ObjectContext;
            }
        }

        public ObjectContext ObjectContextAudit
        {
            get
            {
                return (_dbContextAudit as IObjectContextAdapter).ObjectContext;
            }
        }

        #endregion

        #region Constructor

        //public UnitOfWork(DbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //    //_auditoriaSesionRepositorio = GetRepository<AuditoriaSesion>();
        //    //_auditoriaOperacionRepositorio = GetRepository<AuditoriaOperacion>();
        //}

        // Para unit testing /  inyectar por Ninject

        //public UnitOfWork(DbContext dbContext, DbContext dbContextAudit, IRepository<auditoriasesion> auditoriaSesionRepositorio, IRepository<auditoriaoperacion> auditoriaOperacionRepositorio)
        //{
        //    _dbContext = dbContext;
        //    _dbContextAudit = dbContextAudit;
        //    _auditoriaSesionRepositorio = auditoriaSesionRepositorio;
        //    _auditoriaOperacionRepositorio = auditoriaOperacionRepositorio;
        //}

        public UnitOfWork()
        {
            _dbContext = new DatabaseContext();
            _dbContextAudit = new DatabaseContext("Audit");
            //_auditoriaSesionRepositorio = GetRepositoryAudit<auditoriasesion>();
            //_auditoriaOperacionRepositorio = GetRepositoryAudit<auditoriaoperacion>();
            //_audit = GetRepository<Parametros>().Find("0").audit;//Obtener de parámetros generales.
            ObjectContext.CommandTimeout = 180;

        }

        #endregion

        #region Public Methods

        public IRepository<T> GetRepository<T>() where T : Entidad
        {
            IRepository<T> repositorio;

            repositorio = new Repository<T>(_dbContext);

            return repositorio as IRepository<T>;
        }

        public IRepository<T> GetRepositoryAudit<T>() where T : Entidad
        {
            IRepository<T> repositorio;

            repositorio = new Repository<T>(_dbContextAudit);

            return repositorio as IRepository<T>;
        }

        public RespuestaGenerica SaveChanges(bool ejecutar = false, string userName = "",string userPC="")
        {
            RespuestaGenerica respuesta = new RespuestaGenerica();
            try
            {
                //Auditoria
                if (_audit)
                {
                    if (ejecutar && userName!="" && userPC!="")
                    {
                        foreach (var entry in _dbContext.ChangeTracker.Entries().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified || e.State == EntityState.Deleted))
                        {
                            if (entry.Entity is Entidad)
                            {                                
                                //TrackOperation(entry, userName, userPC);
                                
                            }
                        }

                        _dbContextAudit.SaveChanges();
                    }
                }
                respuesta.NroDeEntidadesModificadas = _dbContext.SaveChanges();


                respuesta.Mensaje = "Operación Efectuada Correctamente";
                respuesta.Ok = true;
                return respuesta;

            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                var outputLines = new List<string>();
                foreach (var eve in ex.EntityValidationErrors)
                {
                    outputLines.Add(string.Format(
                        "{0}: Entidad de tipo \"{1}\" con estado \"{2}\" tiene los siguientes errores de validación:",
                        DateTime.Now, eve.Entry.Entity.GetType().Name, eve.Entry.State));
                    foreach (var ve in eve.ValidationErrors)
                    {
                        outputLines.Add(string.Format(
                            "- Propiedad: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage));
                    }
                }
                System.IO.File.AppendAllLines(@"c:\temp\errores.txt", outputLines);
                respuesta.Mensaje = "Ocurrió un error. Consulte archivo " + @"c:\temp\errores.txt";
                respuesta.Ok = false;
                return respuesta;
            }
            catch (Exception ex)
            {
                respuesta.Mensaje = "Ocurrió un error general. " + ex.InnerException.InnerException.Message;
                //if (ex.InnerException.InnerException!=null)
                //{
                //    respuesta.Mensaje = "Ocurrió un error general. " + ex.InnerException.InnerException.Message;
                //}
                //else
                //{
                //    respuesta.Mensaje = "Ocurrió un error general. " + ex.Message;
                //}
                
                respuesta.Ok = false;
                return respuesta;
            }
        }

        //public RespuestaGenerica TrackInitSession(string userName, string SysVersion,string usuarioIP, string userPC)
        //{
        //    RespuestaGenerica respuesta = new RespuestaGenerica();
        //    string ClientIp;
        //    try
        //    {
        //        //ClientIp = GetClientIP();
        //        ClientIp = usuarioIP;
        //        if (_audit)
        //        {
        //            //Validar que el usuario no tenga sessiones abiertas.
        //            List<auditoriasesion> sessions = _auditoriaSesionRepositorio.GetAll().Where(x => x.usu_id.Equals(userName) && x.fechainiciosesion != null && x.fechacierresesion == null && x.hardware== userPC).ToList();
        //            //Cierra todas las sesiones abiertas
        //            if (sessions != null)
        //            {
        //                foreach (auditoriasesion session in sessions)
        //                {
        //                    session.fechacierresesion = DateTime.Now;
        //                    _auditoriaSesionRepositorio.Update(session);
        //                }
                        
        //            }

        //            _auditoriaSesionRepositorio.Add(new auditoriasesion
        //            {
        //                fechainiciosesion = DateTime.Now,
        //                ip = ClientIp,
        //                navegador = null,
        //                sysversion = SysVersion,
        //                usu_id = userName,
        //                hardware=userPC

        //            });

        //            respuesta.NroDeEntidadesModificadas = _dbContextAudit.SaveChanges();
        //            respuesta.Ok = true;
        //            respuesta.Mensaje = "Operación Efectuada Correctamente";
                    
        //        }
        //        else
        //        {
        //            respuesta.Ok = true;

        //        }
        //        //Devuelve la con la que se registró el cliente
        //        //respuesta.UltimoIdInsertado = ClientIp;
        //    }

        //    catch (Exception ex)
        //    {
        //        respuesta.Mensaje = "Error en registro de Inicio de Sessión. " + ex.InnerException.InnerException.Message;
        //        respuesta.Ok = false;

        //    }
        //    return respuesta;           
        //}

        //public RespuestaGenerica TrackCloseSession(auditoriasesion session)
        //{
        //    RespuestaGenerica respuesta = new RespuestaGenerica();

        //    try
        //    {
        //        if (_audit)
        //        {
        //            session.fechacierresesion = DateTime.Now;
        //            respuesta.NroDeEntidadesModificadas = _dbContextAudit.SaveChanges();
        //            respuesta.Ok = true;
        //            respuesta.Mensaje = "Operación Efectuada Correctamente";

        //        }
        //        else
        //        {
        //            respuesta.Ok = true;

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        respuesta.Mensaje = "Error en registro de Cierre de Sessión. " + ex.InnerException.InnerException.Message;
        //        respuesta.Ok = false;

        //    }

        //    return respuesta;
        //}

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        #region Private Methods

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                    _dbContextAudit.Dispose();
                }
            }

            _disposed = true;
        }

        private static string GetClientIP()
        {
            //Metodo Original
            //var szRemoteAddr = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            //var szXForwardedFor = HttpContext.Current.Request.ServerVariables["X_FORWARDED_FOR"];
            //return szXForwardedFor + " / " + szRemoteAddr;

            string ip = "";
            IPHostEntry ipEntry = Dns.GetHostEntry(GetCompCode());
            IPAddress[] addr = ipEntry.AddressList;
            foreach (IPAddress dirIp in addr)
            {
                if (dirIp.AddressFamily == AddressFamily.InterNetwork)
                {
                    ip = dirIp.ToString();
                    break;
                }
            }
            
            return ip;


        }

        public static string GetCompCode()  // Get Computer Name
        {
            string strHostName = "";
            strHostName = Dns.GetHostName();
            return strHostName;
        }

        //private void TrackOperation(DbEntityEntry entry, string userName,string userPC)
        //{
        //    string Id = "";           
        //    var auditAction = (AuditAction)Enum.Parse(typeof(AuditAction), entry.State.ToString(), true);
            
        //    //SESSION
        //    var auditoriaSession = _auditoriaSesionRepositorio.GetAll().SingleOrDefault(x => x.usu_id.Equals(userName) && x.fechacierresesion == null && x.hardware.Equals(userPC));

        //    if (auditoriaSession == null)
        //        throw new NegocioException("Falló el proceso de auditoria");

        //    var entityType = ObjectContext.GetObjectType(entry.Entity.GetType());

        //    //Obtiene nombre de Primary Key de entidad
        //    if (auditAction == AuditAction.Added)
        //    {
        //        Id = entry.Entity.GetType().GetProperties()[0].Name;
        //    }
        //    else
        //    {
        //        Id = ObjectContext.ObjectStateManager.GetObjectStateEntry(entry.Entity).EntityKey.EntityKeyValues.FirstOrDefault().Key;
        //    }


        //    var operation = new auditoriaoperacion
        //    {               
        //        accion = auditAction.GetDescription(),
        //        auditoriasesionid = auditoriaSession.id,
        //        fechaoperacion = DateTime.Now,
        //        entidadnombre = entityType.Name,
        //        entidadid = entry.Entity.GetType().GetProperty(Id).GetValue(entry.Entity).ToString()
        //    };            

        //    //Almacena OperaciónDetalle
        //    foreach (var serializedItem in AuditSerializer.GetSerializedEntity(entry, Id))
        //    {
        //        operation.auditoriaoperaciondetalle.Add(new auditoriaoperaciondetalle
        //        {
        //            auditoriaoperacionid = operation.id,
        //            xmloperacion = serializedItem
        //        });
        //    }

        //    _auditoriaOperacionRepositorio.Add(operation);

            
        //}

        //Método que almacena registro de Auditoría "Libre" sin EF
        /// <summary>
        /// Guardar registro de Auditoría para Operaciones que no están "ligadas" a estados de EF
        /// por Ej. Autorizar, consultar, etc.
        /// </summary>
        /// <param name="entidad">Entidad en cuestión</param>
        /// <param name="idEntidad">Id de Entidad Involucrada</param>
        /// <param name="accion">Tipo de acción a auditar (Enum AuditAction)</param>
        /// <param name="userName">Usuario que realiza la operación</param>
        //public void TrackOperationFree(string entidad, string idEntidad, AuditAction accion, string userName, string usuariosPC)
        //{
        //    try
        //    {
        //        if (_audit)
        //        {
        //            //SESSION
        //            var auditoriaSession = _auditoriaSesionRepositorio.GetAll().SingleOrDefault(x => x.usu_id.Equals(userName) && x.hardware.Equals(usuariosPC)  && x.fechacierresesion == null);

        //            if (auditoriaSession == null)
        //                throw new NegocioException("Falló el proceso de auditoria");

        //            var operation = new auditoriaoperacion
        //            {
        //                accion = accion.GetDescription(),
        //                auditoriasesionid = auditoriaSession.id,
        //                fechaoperacion = DateTime.Now,
        //                entidadnombre = entidad,
        //                entidadid = idEntidad
        //            };

        //            _auditoriaOperacionRepositorio.Add(operation);
        //            _dbContextAudit.SaveChanges();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new NegocioException(ex.InnerException.InnerException.Message);

        //    }

        //}

        #endregion

    }
}
