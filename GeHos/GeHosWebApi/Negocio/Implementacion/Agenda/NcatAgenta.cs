using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.ObjectModel;
using Utiles.RespuestaGenerica;
using GeHosContract.Contrato;
using GeHosWebApi.Models;

namespace GeHosWebApi
{
    public class NcatAgenta : Negocio<catAgenda>, IcatAgenda
    {
        #region Constructores

        public NcatAgenta(IUnitOfWork uow) : base(uow) { }

        public NcatAgenta() { }

        #endregion

        public catAgendaVM TraerEntidad(object entidad)
        {

            var id = ((object[])entidad)[0];

            var periodo = _repositorio.Find(id);

            catAgendaVM item = new catAgendaVM();

            MapObjects(periodo, item);

            item.Ok = true;

            return item;
        }

        public CcatAgendaVM TraerEntidades(object entidad)
        {
            CcatAgendaVM resultado = new CcatAgendaVM();
            var repoCS = _unitOfWork.GetRepository<catCentroDeSalud>().GetAll();
            var repoEsp = _unitOfWork.GetRepository<catEspecialidad>().GetAll();

            resultado.ListaItems = new ObservableCollection<catAgendaVM>(_repositorio.GetAll().Where(p => p.agActivo == true).Select(res => new catAgendaVM()
            {
                #region MappingsTEs
                agActivo = res.agActivo,
                agDuracion = res.agDuracion,
                agEstado = res.agEstado,
                agId = res.agId,
                agSobreturnos = res.agSobreturnos,
                conId = res.conId,
                csId = res.csId,
                csNombre = repoCS.Where(x => x.csId == res.csId).Select(y => y.csNombre).FirstOrDefault(),
                espId = res.espId,
                espNombre = repoEsp.Where(x => x.espId == res.espId).Select(y => y.espNombre).FirstOrDefault(),
                perId=res.perId
                #endregion MappingsTEs
            }).OrderByDescending(p => p.agId));

            resultado.Ok = true;

            return resultado;
        }

        public CcatAgendaVM TraerTodasAgendas()
        {
            CcatAgendaVM resultado = new CcatAgendaVM();
            var repoCS = _unitOfWork.GetRepository<catCentroDeSalud>().GetAll();
            var repoEsp = _unitOfWork.GetRepository<catEspecialidad>().GetAll();

            resultado.ListaItems = new ObservableCollection<catAgendaVM>((from agendas in _repositorio.GetAll()
                                                                          join centroSalud in repoCS on agendas.csId equals centroSalud.csId into cs_join
                                                                          from centroSalud in cs_join.DefaultIfEmpty()
                                                                          join especialidad in repoEsp on agendas.espId equals especialidad.espId into esp_join
                                                                          from especialidad in esp_join.DefaultIfEmpty()
                                                                          select new
                                                                          {
                                                                              #region MappingsTEs
                                                                              agActivo = agendas.agActivo,
                                                                              agDuracion = agendas.agDuracion,
                                                                              agEstado = agendas.agEstado,
                                                                              agId = agendas.agId,
                                                                              agSobreturnos = agendas.agSobreturnos,
                                                                              conId = agendas.conId,
                                                                              csId = agendas.csId,
                                                                              csNombre = centroSalud.csNombre,
                                                                              espId = agendas.espId,
                                                                              espNombre = especialidad.espNombre,
                                                                              perId = agendas.perId
                                                                              #endregion MappingsTEs
                                                                          }).Take(50).ToList().Select(obj => new catAgendaVM()
                                                                          {
                                                                              #region MappingsTEs
                                                                              agActivo = obj.agActivo,
                                                                              agDuracion = obj.agDuracion,
                                                                              agEstado = obj.agEstado,
                                                                              agId = obj.agId,
                                                                              agSobreturnos = obj.agSobreturnos,
                                                                              conId = obj.conId,
                                                                              csId = obj.csId,
                                                                              csNombre = obj.csNombre,
                                                                              espId = obj.espId,
                                                                              espNombre = obj.espNombre,
                                                                              perId = obj.perId
                                                                              #endregion MappingsTEs
                                                                          }
                                                                        ));

            //resultado.ListaItems = new ObservableCollection<catAgendaVM>(_repositorio.GetAll().Take(50).ToList().Where(p => p.agActivo == true).Select(res => new catAgendaVM()
            //{
            //    #region MappingsTEs
            //    agActivo = res.agActivo,
            //    agDuracion = res.agDuracion,
            //    agEstado = res.agEstado,
            //    agId = res.agId,
            //    agSobreturnos = res.agSobreturnos,
            //    conId = res.conId,
            //    csId = res.csId,
            //    csNombre = repoCS.Where(x => x.csId == res.csId).Select(y => y.csNombre).FirstOrDefault(),
            //    espId = res.espId,
            //    espNombre = repoEsp.Where(x => x.espId == res.espId).Select(y => y.espNombre).FirstOrDefault(),
            //    perId = res.perId
            //    #endregion MappingsTEs
            //}).OrderByDescending(p => p.agId));

            resultado.Ok = true;

            return resultado;
        }

        public RespuestaGenerica AgregarEntidad(object entidad)
        {
            var entidadEditada = (catAgendaVM)((object[])entidad)[0];
            //Crea una nueva instancia de Entidad
            catAgenda entidadNueva = new catAgenda();
            MapObjects(entidadEditada, entidadNueva);
            //Agrega al repositorio de Entidad una nueva Entidad
            _repositorio.Add(entidadNueva);

            //Confirma datos en BD a traves del UoF
            return _unitOfWork.SaveChanges();
        }

        public RespuestaGenerica ActualizarEntidad(object entidad)
        {
            var entidadEditada = (catAgendaVM)((object[])entidad)[0];
            object codigo = entidadEditada.agId;
            //Busca Entidad en DB
            catAgenda entidadBase = _repositorio.Find(codigo);

            MapObjects(entidadEditada, entidadBase);

            _repositorio.Update(entidadBase);

            //Confirma datos en BD a traves del UoF
            return _unitOfWork.SaveChanges();
        }

        public RespuestaGenerica RemoverEntidad(object entidad)
        {
            var codigo = ((catAgendaVM)((object[])entidad)[0]).agId;

            //Obtiene Entidad a Eliminar
            catAgenda entidadBaja = _repositorio.Find(codigo);
            //Elimina del repositorio Entidad de BD
            _repositorio.Remove(entidadBaja);

            //Confirma datos en BD a traves del UoF
            return _unitOfWork.SaveChanges();
        }
    }
}