/************************************************************************************************************
 * Descripción: Clase Negocio Entidad catAgendaHorario.
 * Observaciones: 
 * Creado por: MC.
 * Historial de Revisiones:
 * -----------------------------------------------------------------------------------------------
 * Fecha        Evento / Método Autor   Descripción
 * -----------------------------------------------------------------------------------------------
 * 07/12/2016					Implementación inicial.
 * -----------------------------------------------------------------------------------------------
*/
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Web;
using Utiles.RespuestaGenerica;
using GeHosWebApi.Models;
using GeHosContract.Contrato;

namespace GeHosWebApi
{
    public class NcatAgendaHorario : Negocio<catAgendaHorario>, IcatAgendaHorario
    {
        #region Constructores 

        public NcatAgendaHorario(IUnitOfWork uow) : base(uow) { }

        public NcatAgendaHorario() { }

        #endregion

        public catAgendaHorarioVM TraerEntidad(object entidad)
        {

            var id = ((object[])entidad)[0];

            var catagendahorario = _repositorio.Find(id);

            catAgendaHorarioVM item = new catAgendaHorarioVM();

            MapObjects(catagendahorario, item);

            item.Ok = true;

            return item;
        }

        public CcatAgendaHorarioVM TraerEntidades(object parametros)
        {

            CcatAgendaHorarioVM resultado = new CcatAgendaHorarioVM();

            resultado.ListaItems = new ObservableCollection<catAgendaHorarioVM>(_repositorio.GetAll().Select(res => new catAgendaHorarioVM()
            {
                #region MappingsTEs
                aghId = res.aghId,
                aghDiaSemana = res.aghDiaSemana,
                aghHoraInicio = res.aghHoraInicio,
                aghMinutoInicio = res.aghMinutoInicio,
                aghHoraFin = res.aghHoraFin,
                aghMinutoFin = res.aghMinutoFin,
                aghVigenciaDesde = res.aghVigenciaDesde,
                aghVigenciaHasta = res.aghVigenciaHasta,
                agId = res.agId,
                aghActivo = res.aghActivo,
                aghCantTurnos = res.aghCantTurnos,
                aghSobreturnos = res.aghSobreturnos,
                aghTipoAgenda = res.aghTipoAgenda,
                #endregion MappingsTEs
            }));

            resultado.Ok = true;

            return resultado;

        }

        public RespuestaGenerica AgregarEntidad(object entidad)
        {
            var entidadEditada = (catAgendaHorarioVM)((object[])entidad)[0];

            //Crea una nueva instancia de Entidad
            catAgendaHorario entidadNueva = new catAgendaHorario();

            MapObjects(entidadEditada, entidadNueva);

            //Agrega al repositorio de Entidad una nueva Entidad
            _repositorio.Add(entidadNueva);

            //Confirma datos en BD a traves del UoF
            return _unitOfWork.SaveChanges();
        }

        public RespuestaGenerica ActualizarEntidad(object entidad)
        {
            var entidadEditada = (catAgendaHorarioVM)((object[])entidad)[0];

            object codigo = entidadEditada.aghId;

            //Busca Entidad en DB
            catAgendaHorario entidadBase = _repositorio.Find(codigo);

            MapObjects(entidadEditada, entidadBase);

            //Actualiza repositorio de Entidad
            _repositorio.Update(entidadBase);

            //Confirma datos en BD a traves del UoF
            return _unitOfWork.SaveChanges();
        }

        public RespuestaGenerica RemoverEntidad(object entidad)
        {
            var codigo = (catAgendaHorarioVM)((object[])entidad)[0];

            //Obtiene Entidad a Eliminar
            catAgendaHorario entidadBaja = _repositorio.Find(codigo);

            //Elimina del repositorio Entidad de BD
            _repositorio.Remove(entidadBaja);

            //Confirma datos en BD a traves del UoF
            return _unitOfWork.SaveChanges();
        }

    }
}
