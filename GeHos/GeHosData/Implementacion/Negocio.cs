namespace GeHosData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Data.SqlClient;
    using Utiles.RespuestaGenerica;
    using GeHosContract.Contrato;

    public class Negocio<T> : INegocio<T> where T : Entidad
    {
        #region Propiedades

        protected readonly IRepository<T> _repositorioAudit;
        protected readonly IRepository<T> _repositorio;
        protected readonly IUnitOfWork _unitOfWork;

        protected string User { get; set; }
        protected string userPC { get; set; }
        #endregion

        #region constructor

        public Negocio(IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
            _repositorio = _unitOfWork.GetRepository<T>();
            _repositorioAudit = _unitOfWork.GetRepositoryAudit<T>();
        }

        public Negocio()
        {
            _unitOfWork = new UnitOfWork();
            _repositorio = _unitOfWork.GetRepository<T>();
            _repositorioAudit = _unitOfWork.GetRepositoryAudit<T>();

        }

        #endregion

        #region Metodos Publicos

        public virtual T Find(object id)
        {
            try
            {
                var entity = _repositorio.Find(id);

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al obtener el item", ex);
            }
        }

        public virtual IList<T> GetAll()
        {
            return GetAllIq().ToList();
        }

        public virtual IQueryable<T> GetAllIq()
        {
            try
            {
                var entities = _repositorio.GetAll();

                return entities;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al obtener los items", ex);
            }
        }

        public virtual void Add(T item)
        {
            try
            {
                _repositorio.Add(item);
                //_unitOfWork.SaveChanges();
            }

            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al crear el item", ex);
            }
        }

        public virtual void Update(T item)
        {
            try
            {
                //ComunHelper.ActualizarDatosEnMayusculas(item);
                _repositorio.Update(item);
                //_unitOfWork.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al editar el item", ex);
            }
        }

        public virtual void Remove(object id)
        {
            try
            {
                var item = _repositorio.Find(id);
                _repositorio.Remove(item);

                //_unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al eliminar el item", ex);
            }
        }

        public virtual void Commit(bool execAudit = true)
        {
            try
            {
                _unitOfWork.SaveChanges(execAudit);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al querer grabar los datos", ex);
            }
        }

        #region Usuario
        public virtual string GetUser()
        {
            return User;
        }

        public virtual void SetUser(object entidad)
        {
            var user = ((List<string>)entidad)[0];
            this.User = user;
        }
        public virtual string GetUserPC()
        {
            return userPC;
        }

        public virtual void SetUserPC(object entidad)
        {
            var userPC = ((List<string>)entidad)[0];
            this.userPC = userPC;
        }

        #endregion


        #region ProximoID

        /// <summary>
        /// Devuelve el proximo valor a insertar, obtenido desde una secuencia
        /// </summary>
        /// <param name="nombreTabla">Nombre de la tabla de la cual se desea obetener el proximo ID para insertar, con el formato '0000000000'</param>
        /// <returns>Devuelve un string con el formato '0000000000'</returns>
        public RespuestaGenerica TraerProximoID(string nombreTabla)
        {

            RespuestaGenerica respuesta = new RespuestaGenerica();

            var @params = new[] { new SqlParameter("Tabla", nombreTabla) };

            int res = _unitOfWork.ObjectContext.ExecuteStoreQuery<int>("EXEC ProcSecuencia @Tabla", @params).FirstOrDefault();

            if (res > 0)
            {
                respuesta.UltimoIDObtenido = res.ToString().PadLeft(10, '0');
                respuesta.Ok = true;
            }
            else
            {
                respuesta.Ok = false;
                switch (res)
                {
                    case -1: //--Retorno: -1 - El nombre de la tabla debe tener al menos 1 caracter
                        respuesta.Mensaje = "El nombre de la tabla debe tener al menos 1 caracter";
                        break;
                    case -2: //--Retorno: -2 - La tabla especificada no tiene secuencia asociada
                        respuesta.Mensaje = "La tabla especificada no tiene secuencia asociada";
                        break;
                    case -3: //--Retorno: -3 - Se produjo un error al invocar la secuencia
                        respuesta.Mensaje = "Se produjo un error al invocar la secuencia";
                        break;
                    case -4: //--Retorno: -4 - La tabla especificada no existe
                        respuesta.Mensaje = "La tabla especificada no existe";
                        break;
                    default:
                        respuesta.Mensaje = "";
                        break;
                }
            }

            return respuesta;
        }
        #endregion

        #endregion


        #region Metodos Privados


        protected static object MapObjects(object origen, object destino)
        {
            var propiedadesDestino = destino.GetType().GetProperties();
            foreach (var destinoProp in propiedadesDestino)
            {
                try
                {
                    var origenProp = origen.GetType().GetProperty(destinoProp.Name);

                    if (origenProp != null) //Agregado 24/04/2015 por error detectado en lista de Favoritos y Recientes
                    //Se saca un item de favoritos a Recientes y al cerrar sesion la aplicación lanza excepcion
                    {
                        if (origenProp.GetValue(origen, null) != null)
                        {
                            destinoProp.SetValue(destino, origenProp.GetValue(origen));
                        }
                        else
                        {
                            if (IsNullable(destinoProp.PropertyType))
                            {
                                destinoProp.SetValue(destino, null);
                            }
                        }
                    }
                }
                catch(Exception )
                { }
            }

            return destino;
        }

        static bool IsNullable(Type type)
        {
            return Nullable.GetUnderlyingType(type) != null;
        }

        #endregion
    }
}
